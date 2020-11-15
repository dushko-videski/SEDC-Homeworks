use SEDCHome

--Create multi-statement table value function that for specific Teacher and Course will return: -
--1.list of students (FirstName, LastName) who passed the exam, together with 
--2.Grade and 
--3.CreatedDate
select * from [dbo].[AchievementType] -- exam, id = 5
select * from [dbo].[Grade] -- Grade, CreateDate
select * from [dbo].[Course] --name od course
select * from [dbo].[Student] --FirstName, LastName
select * from [dbo].[Teacher]
select * from [dbo].[GradeDetails]
where AchievementTypeID = 5

create function dbo.fn_StudentGradeCreateDate (@TeacherId smallint, @CourseId smallint)
returns @result table (FirstName nvarchar (50), LastName nvarchar(50), Grade tinyint, CreatedDate datetime, Acht int)

as
begin

	insert into @result (FirstName, LastName, Grade, CreatedDate, Acht )

	select s.FirstName, s.LastName, g.Grade, g.CreatedDate, acht.ID

	from dbo.Grade g
	inner join dbo.GradeDetails gd
	on gd.GradeID = g.ID
	inner join dbo.Student s
	on g.StudentID = s.ID
	inner join dbo.AchievementType acht
	on acht.ID = gd.AchievementTypeID
	where g.TeacherID = @TeacherId and g.CourseID = @CourseId
	group by s.FirstName, s.LastName, g.Grade, g.CreatedDate, acht.ID
	having acht.ID = 5

	return
end

select * from dbo.fn_StudentGradeCreateDate(1,1)

drop function dbo.fn_StudentGradeCreateDate


