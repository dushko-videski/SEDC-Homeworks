use sedc
create table dbo.businessentity_details (
	ID int identity (1,1) not null, 
	BusinessentityID int,
	AccountNumber nvarchar(15),
	Address nvarchar (250),
	Contact nvarchar (100),
	email nvarchar(250),
	comment nvarchar(max),
	constraint PK_ID primary key (ID),
	--ili samo primary key (ID)
	--foreign key (BusinessentityID) references dbo.BusinessEntity (Id)
)

--ili vaka so ALTER da se dodade FOREIGN KEY:
alter table businessentity_details with check
add constraint FK_businessentity_details_BusinessentityID
foreign key (BusinessentityID)
references dbo.BusinessEntity (Id)

drop table dbo.businessentity_details

--3)Дополнително треба да ги има следните ограничувања:
-------------------------------------------------------
--1)Колоната AccountNumber треба да биде UNIQUE
alter table dbo.businessentity_details with check
add constraint UC_AccNo unique (AccountNumber)


select * from dbo.businessentity_details
where AccountNumber = '210500222335'

update dbo.businessentity_details
set AccountNumber = '210500'
where ID = 3

--2)Колоната email треба да проверува дали содржи знак @ и знак “.”
alter table dbo.businessentity_details with check
add constraint CHK_email
check (email like '%@%.%')

select * from dbo.businessentity_details
where email not like '%@%.%'

update dbo.businessentity_details
set email = 'd1ddvitalia@yahoo.com'
where ID = 4
update dbo.businessentity_details
set email = 'vvv@vitalia.com'
where ID = 5
update dbo.businessentity_details
set email = 'ddd@vitalia.com'
where ID = 6

--3)Првите два знака од колоната Contact треба да бидат 07.

alter table dbo.businessentity_details with check
add constraint CHK_contact
check (substring (Contact, 1, 2) = '07')

--4)Да се направи UPDATE на колона comment со вредност :Nema zabaleshka za smetka на сите редови од табелата dbo.businessentity_details

update dbo.businessentity_details
set comment = 'Nema zabaleshka za smetka'

--5)Да се искреира функција за пресметка на вкупна количина на нарачки по продукт

create function dbo.TotalQuantity (@ProductId int)
returns int
as 
begin
	declare @result int
	select @result = sum(Quantity)
	from dbo.OrderDetails 
	where ProductId = @ProductId
	group by ProductId
	return @result
end

drop function dbo.TotalQuantity

select *, dbo.TotalQuantity(1) as total
from dbo.OrderDetails

--6)Да се искреира функција за пресметка на вкупна сума на нарачки по продукт

create function dbo.fn_SumPrice (@productPrice int)
returns int
as
begin
	declare @result int
	select @result = sum(Price) 
	from dbo.OrderDetails
	where Id = @productPrice


	return @result
end

drop function dbo.fn_SumPrice

select dbo.fn_SumPrice(7)

--7) Потребно е да се направи view за приказ на:
-----------------------------------------------
---име на компанија
---регион(пошта - име на регион)
---број на сметка
---адреса, вредноста XXXX да се замени со ‘Улица број’
---име на продукт
---вкупна продадена количина по продукт да биде во податочен тип int
---вкупна сума по продукт да биде дополнета со валута МКД

--Во искреираното view колоните да се прикажат на кирилица и 
--податоците во колоните за: 
--име на комапнија, 
--име на регион и 
--име на продукт 
--исто така да бидат на кирилица.

--View-то да прикажува само ставки за продукт со име Granola.

--На крај да се направи подредување по колона Име на компанија

create view dbo.vv_CompanyDetails
as
select 
	dbo.ToCyrillic(be.[Name]) as [Име на компанија], 
	concat (be.Zipcode, '-', dbo.ToCyrillic(be.Region)) as [Име на регион], 
	bed.AccountNumber as [Број на сметка], 
	dbo.ToCyrillic(replace (bed.[Address], 'XXXX', N'Улица број')) as [Адреса],
	dbo.ToCyrillic(p.[Name]) as [Име на продукт], 
	sum(od.Quantity) as [Вкупна продадена количина], 
	--dbo.TotalQuantity(p.Id) as [Вкупна продадена количина],
	concat(sum(od.Quantity) * p.Price, N'  МКД') as [Вкупна сума по продукт]
	--concat(dbo.TotalQuantity(p.Id, N'  МКД') as [Вкупна сума по продукт]

	from dbo.BusinessEntity be
	inner join dbo.businessentity_details bed on be.Id = bed.BusinessentityID
	inner join dbo.[Order] o on o.BusinessEntityId = be.Id
	inner join dbo.OrderDetails od on o.Id = od.OrderId
	inner join dbo.Product p on p.Id = od.ProductId
	where p.[Name] = 'Granola'
	group by be.[Name], be.Zipcode, be.Region, bed.AccountNumber, bed.[Address], p.[Name], p.Id, p.Price

drop view dbo.vv_CompanyDetails	

select * from vv_CompanyDetails



select * from [dbo].[BusinessEntity] --Name of company and Region
select * from [dbo].[businessentity_details] --Account and Address
select * from [dbo].[Order]
select * from [dbo].[OrderDetails]
select * from [dbo].[Product]
where [Name] = 'Granola'


	

