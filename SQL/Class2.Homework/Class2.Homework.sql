use SEDCHome
--Homework requirement 1/6
--------------------------
--Find all Students with FirstName = Antonio
select *
from dbo.Student
where FirstName = 'Antonio'
--Find all Students with DateOfBirth greater than ‘01.01.1999’
select *
from dbo.Student
where DateOfBirth > '1/1/1999'
--Find all Male students
select *
from dbo.Student
where Gender = 'M'
--Find all Students with LastName starting With ‘T’
select *
from dbo.Student
where LastName like 'T%'
--Find all Students Enrolled in January/1998
select *
from dbo.Student
where EnrolledDate between '1/1/1998' and '1/31/1998'
--Find all Students with LastName starting With ‘J’ enrolled in January/1998
select *
from dbo.Student 
where LastName like 'J%' and EnrolledDate between '1/1/1998' and '1/31/1998'

--Homework requirement 2/6
--------------------------
--Find all Students with FirstName = Antonio ordered by Last Name
select * 
from dbo.Student
where FirstName = 'Antonio'
order by LastName
--List all Students ordered by FirstName
select *
from dbo.Student
order by FirstName
--Find all Male students ordered by EnrolledDate, starting from the last enrolled
select *
from dbo.Student
where Gender = 'M' 
order by EnrolledDate desc

--Homework requirement 3/6
--------------------------
--List all Teacher First Names and Student First Names in single result set with duplicates
select FirstName
from dbo.Teacher
union all
select FirstName
from dbo.Student
--List all Teacher Last Names and Student Last Names in single result set. Remove duplicates
select LastName
from dbo.Teacher
union
select LastName
from dbo.Student
--List all common First Names for Teachers and Students
select FirstName
from dbo.Teacher
intersect
select FirstName
from dbo.Student

--Homework requirement 4/6
--------------------------
--Change GradeDetails table always to insert value 100 in AchievementMaxPoints column if no value is provided on insert
alter table dbo.GradeDetails
add constraint DF_Ach_Max_Points
default 100 for AchievementMaxPoints
--Change GradeDetails table to prevent inserting AchievementPoints that will more than AchievementMaxPoints
alter table GradeDetails with check
add constraint CHK_Ach_Points
check (AchievementPoints <= AchievementMaxPoints)
--Change AchievementType table to guarantee unique names across the Achievement types
alter table AchievementType with check
add constraint UC_Ach_Type unique (Name)

--Homework requirement 5/6
--------------------------
--Create Foreign key constraints from diagram or with script
alter table dbo.Grade with check
add constraint FK_Grade_TeacherID
foreign key (TeacherID)
references dbo.Teacher (ID)

alter table dbo.Grade with check
add constraint FK_Grade_CourseID
foreign key (CourseID)
references dbo.Course (ID)

alter table dbo.Grade with check
add constraint FK_Grade_StudentID
foreign key (StudentID)
references dbo.Student (ID)

alter table dbo.GradeDetails with check
add constraint FK_GradeDetails_AchievementTypeID
foreign key (AchievementTypeID)
references dbo.AchievementType (ID)

alter table dbo.GradeDetails with check
add constraint FK_GradeDetails_GradeID
foreign key (GradeID)
references dbo.Grade (ID)

--Homework requirement 6/6
--------------------------
--List all possible combinations of Courses names and AchievementType names that can be passed by student
select c.Name, a.Name
from dbo.Course c
cross join dbo.AchievementType a

--List all Teachers that has any exam Grade
select concat(t.FirstName,'',t.LastName) as [Teacher Full Name], g.Grade
from dbo.Teacher t
inner join dbo.Grade g
on t.ID = g.TeacherID

--List all Teachers without exam Grade
select concat(t.FirstName,'',t.LastName) as [Teacher Full Name], g.Grade
from dbo.Teacher t
left join dbo.Grade g
on t.ID = g.TeacherID
where g.Grade is null

--List all Students without exam Grade (using Right Join)
select s.FirstName, s.LastName, g.Grade
from dbo.Student s
right join dbo.Grade g
on s.id = g.StudentID
where g.Grade is null

select * from AchievementType
select * from Course
select * from Student
select * from dbo.Grade
select * from Teacher





