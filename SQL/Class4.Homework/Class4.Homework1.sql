--Homework requirement 1/2
---------------------------
--Declare scalar variable for storing FirstName values
	--Assign value ‘Antonio’ to the FirstName variable
	--Find all Students having FirstName same as the variable
declare @FirstName nvarchar (50)
set @FirstName = 'Antonio'

select *
from dbo.Student
where FirstName = @FirstName

go

--Declare table variable that will contain StudentId, StudentName and DateOfBirth
	--Fill the table variable with all Female students
declare @NewTable table
(StudentId int, StudentName nvarchar (50), DateOfBirth date)

insert into @NewTable
select ID, FirstName, DateOfBirth
from dbo.Student
where Gender = 'F'

select * from @NewTable

go

--Declare temp table that will contain LastName and EnrolledDate columns
	--Fill the temp table with all Male students having First Name starting with ‘A’
	--Retrieve the students from the table which last name is with 7 characters
create table #TempTable 
(LastName nvarchar (20), EnrollDate date)

insert into #TempTable
select LastName, EnrolledDate
from dbo.Student
where FirstName like 'A%' and Gender = 'M'

select * 
from #TempTable
where len(LastName) = 7

--Find all teachers whose FirstName length is less than 5 and the first 3 characters of their FirstName and LastName are the same
select *
from dbo.Teacher
where len(FirstName) < 5 and left(FirstName, 3) = left(LastName, 3)

