--Homework requirement 1a/2​
--Create new procedure called CreateGrade​
--1.Procedure should create only Grade header info (not Grade Details) ​
--2.Procedure should return the total number of grades in the system for the Student on input (from the CreateGrade)​
--3.Procedure should return second resultset with the MAX Grade of all grades for the Student and Teacher on input (regardless the Course)

create procedure dbo.CreateGrade (
@StudentId int, 
@CourseId smallint, 
@TeacherId smallint, 
@Grade tinyint,
@CreatedDate datetime)

as
begin
	insert into dbo.Grade(StudentID, CourseID, TeacherID, Grade, CreatedDate)
	values (@StudentId, @CourseId, @TeacherId, @Grade, @CreatedDate)

	select count(*) as TotalGradesForStudent 
	from dbo.Grade
	where StudentID = @StudentId

	select max(Grade) as MaxGrade
	from dbo.Grade
	where StudentID = @StudentId and TeacherID = @TeacherId
end

execute dbo.CreateGrade '372', '3', '3', '8', '2020.08.18' 
select * from dbo.Grade
order by CreatedDate desc


--Homework requirement 1b/2
--Create new procedure called CreateGradeDetail​
--Procedure should add details for specific Grade (new record for new AchievementTypeID, Points, MaxPoints, Date for specific Grade)​
--Output from this procedure should be resultset with SUM of GradePoints calculated with formula AchievementPoints/AchievementMaxPoints*ParticipationRate for specific Grade


create procedure dbo.CreateGradeDetail (
@GradeId int,
@AchievementTypeID tinyint, 
@Points tinyint, 
@MaxPoints tinyint, 
@Date datetime)
as
begin
	insert into dbo.GradeDetails (GradeID, AchievementTypeID, AchievementPoints, AchievementMaxPoints, AchievementDate)
	values (@GradeId, @AchievementTypeID, @Points, @MaxPoints, @Date)

	select gd.AchievementPoints/gd.AchievementMaxPoints*acht.ParticipationRate as [SUM of GradePoints]
	from dbo.GradeDetails gd
	inner join dbo.AchievementType acht
	on gd.AchievementTypeID = acht.ID
	where GradeID = @GradeId
	
end

execute dbo.CreateGradeDetail '12', '5', '90', '50', '2020.08.18'

select * from dbo.GradeDetails
order by AchievementDate desc