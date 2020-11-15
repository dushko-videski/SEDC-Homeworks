--create database HOMEWORKS
--use HOMEWORKS

--create table Teacher
--(
--	Id smallint identity (1,1) not null,
--	FirstName nvarchar(50) not null,
--	LastName nvarchar(50) not null,
--	DateOfBirth date not null,
--	AcademicRank nvarchar(50) not null,
--	HireDate date not null
--	constraint pk_Teacher primary key clustered (Id asc)
--)

--create table Grade
--(
--	ID int identity (1,1) not null,
--	StudentId int not null,
--	CourseId smallint not null,
--	TeacherId smallint not null,
--	Grade tinyint not null,
--	Comment nvarchar(100) null,
--	CreatedDate datetime not null,
--	constraint pk_Grade primary key clustered (ID asc)
--)

--create table Student
--(
--	Id smallint identity (1,1) not null,
--	FirstName nvarchar(50) not null,
--	LastName nvarchar(50) not null,
--	DateOfBirth date not null,
--	EnrolledDate date not null,
--	Gender nchar(1) not null,
--	NationalIdNumber nvarchar(20) not null,
--	StudentCardNumber nvarchar(6) not null,
--	constraint pk_Student primary key clustered (Id asc)
--)

--create table Course
--(
--	ID smallint identity (1,1) not null,
--	Name nvarchar(20) not null,
--	Credit tinyint null,
--	AcademicYear smallint not null,
--	Semestar tinyint null,
--	constraint pk_Course primary key clustered (ID asc)
--)

--create table AchivmentType
--(
--	ID smallint identity (1,1) not null,
--	Name nvarchar(20) not null,
--	Description nvarchar(20) null,
--	ParticipationRate decimal(4,2) null,
--	constraint pk_AchivmentType primary key clustered (ID asc)
--)

--create table GradeDetails
--(
--	ID smallint identity (1,1) not null,
--	GradeID smallint not null,
--	AchivmentTypeID smallint not null,
--	AchivmentPoint tinyint not null,
--	AchivmentMaxPoint tinyint not null,
--	AchivmentDate date null,
--	constraint pk_GradeDetails primary key clustered (ID asc)
--)



