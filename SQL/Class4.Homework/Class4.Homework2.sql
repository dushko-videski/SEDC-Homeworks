--Homework requirement 2/2
--------------------------
--Declare scalar function (fn_FormatStudentName) for retrieving the Student description for specific StudentId in the following format:
--StudentCardNumber without “sc-”
--“ – “
--First character of student FirstName
--“.”
--Student LastName

create function dbo.fn_FormatStudentName (@StudentId int)
returns nvarchar (50)
as
begin

declare @result nvarchar (50)
	
	select @result = concat (replace(StudentCardNumber, 'sc-', ''), '-', left(FirstName, 1), '.', LastName)
	-- ili vaka: right(StudentCardNumber, 5)
	from dbo.Student
	where ID = @StudentId
		
return @result
end

select dbo.fn_FormatStudentName(2) as Description
