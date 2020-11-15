use SEDCHome

--Homework requirement 1/3
--Calculate the count of all grades in the system
select count(*) as TotalGrades
from dbo.Grade

--Calculate the count of all grades per Teacher in the system
select TeacherID, count(*) TotalGrades 
from dbo.Grade
group by TeacherID
--or by Teacher name
select t.FirstName + ' ' + t.LastName as [Teacher's FullName], count(*) TotalGrades 
from dbo.Grade g
inner join dbo.Teacher t
on t.ID = g.TeacherID 
group by t.FirstName + ' ' + t.LastName

--Calculate the count of all grades per Teacher in the system for first 100 Students (ID < 100)
select TeacherID, count(*) TotalGrades 
from dbo.Grade
where StudentID < 100
group by TeacherID

--Find the Maximal Grade, and the Average Grade per Student on all grades in the system
select s.FirstName + ' ' + s.LastName as [Student's FullName], max(Grade) as MaxGrade, avg(Grade) as AverageGrade
from dbo.Grade g
inner join dbo.Student s
on s.ID = g.StudentID
group by s.FirstName + ' ' + s.LastName
----------------------------------------------

--Homework requirement 2/3
--Calculate the count of all grades per Teacher in the system and filter only grade count greater then 200
select TeacherId, count(*) as TotalGrades
from dbo.Grade
group by TeacherID
having count(*) > 200

--Calculate the count of all grades per Teacher in the system for first 100 Students (ID < 100) and filter teachers with more than 50 Grade count
select TeacherId, count(*) as TotalGrades
from dbo.Grade
where StudentID < 100
group by TeacherID
having count(*) > 50

select * from dbo.Grade

--Find the Grade Count, Maximal Grade, and the Average Grade per Student on all grades in the system. Filter only records where Maximal Grade is equal to Average Grade
select StudentID, count(*) as [Total Grades], max(Grade) as [Max Grade], avg(Grade) as [Average Grade]
from dbo.Grade
group by StudentID
having max(Grade) = avg(Grade) 

--List Student First Name and Last Name next to the other details from previous query
select StudentID, s.FirstName + ' ' +  s.LastName as [Student's Full Name], count(*) as [Total Grades], max(Grade) as [Max Grade], avg(Grade) as [Average Grade]
from dbo.Grade g
inner join dbo.Student s
on s.ID = g.StudentID
group by StudentID, s.FirstName, s.LastName
having max(Grade) = avg(Grade) 
----------------------------------------------------
--Homework requirement 3/3
--Create new view (vv_StudentGrades) that will List all StudentIds and count of Grades per student
create view vv_StudentGrades
as
select StudentID, count(*) TotalGrades
from dbo.Grade
group by StudentID

select * from vv_StudentGrades

--Change the view to show Student First and Last Names instead of StudentID
alter view vv_StudentGrades
as
select s.FirstName as FirstName, s.LastName as LastName, count(*) TotalGrades
from dbo.Grade g
inner join dbo.Student s
on s.ID = g.StudentID
group by s.FirstName, s.LastName

select * from vv_StudentGrades

--List all rows from view ordered by biggest Grade Count
select * 
from vv_StudentGrades
order by TotalGrades desc

--Create new view (vv_StudentGradeDetails) that will List all Students (FirstName and LastName) and Count the courses he passed through the exam(Ispit)

create view vv_StudentGradeDetails
as

select s.FirstName + ' ' + s.LastName as [Student's Full Name], count(CourseID) as CoursesPassed, acht.ID
from dbo.Student s
	inner join dbo.Grade g
	on g.StudentID = s.ID
	inner join dbo.Course c
	on c.ID = g.CourseID
	inner join dbo.GradeDetails gd
	on gd.GradeID = g.ID
	inner join dbo.AchievementType acht
	on acht.ID = gd.AchievementTypeID
where acht.ID = 5
group by s.FirstName + ' ' + s.LastName, s.LastName, acht.ID

select *
from vv_StudentGradeDetails

