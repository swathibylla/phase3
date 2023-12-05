create Database School;
use School;



Create table Classes(
ClassId int Primary key,
ClassName Varchar(50));

insert into Classes(ClassId,ClassName)
Values(1,'Class A');
insert into Classes(ClassId,ClassName)
Values(2,'Class B');
insert into Classes(ClassId,ClassName)
Values(3,'Class c')

	
CREATE TABLE Subjects (
    SubjectId Int Primary key,
    SubjectName Varchar(20));

	insert into Subjects(SubjectId,SubjectName)Values(1,'Maths');
	insert into Subjects(SubjectId,SubjectName)Values(2,'English');
	insert into Subjects(SubjectId,SubjectName)Values(3,'Science');

	CREATE TABLE Student(
	StudentId int Primary key,
	FirstName Varchar(30),
	LastName Varchar(10),
	ClassId int,
	constraint  Fk_Student_Classes Foreign key(ClassId) References Classes(ClassId)
	);

	select ClassId from Classes;

select* from Student;

select StudentId,FirstName,LastName,ClassId from Student;

select ClassId,ClassName from Classes;

select SubjectId,SubjectName from Subjects;

select * from Subjects;