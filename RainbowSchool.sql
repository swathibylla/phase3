CREATE DATABASE RainbowSchool;
use RainbowSchool;



CREATE TABLE Student (
    ID INT PRIMARY KEY,
    Name VARCHAR(100) Not Null,
    Address VARCHAR(100)Not Null,
    Email VARCHAR(75) Not Null,
    Class VARCHAR(5)Not Null
);

  insert into Student (ID,Name, Address, Email,Class) values (1,'Tom', 'Hyderbad', 'tom@email.com','A');
  insert into Student (ID,Name,  Address, Email,Class) values (2,'Thomas',  'Banglore', 'thomas@email.com','B');
  insert into Student (ID,Name, Address, Email,Class) values (3,'Manuel',  'Pune', 'manuelm@email.com','C');
    use RainbowSchool;
  select * from Student;
  select Name from Student;

    update Student set class = 'A';
  update Student set name = 'Tom Clancy' where name = 'Tom';
  
  delete from Student where name = 'Tom Clancy'
  delete from Student

    select * from Student where name like 'Thomas';
  select * from Student where email = 'thomas@email.com' and class='B';
  select * from Student order by name;
  
  declare @Namevalue as varchar(100)
set @Namevalue = 'Mitchell'
 use RainbowSchool;
select * from student where name  = @Namevalue




    



CREATE TABLE Class (
    ID INT PRIMARY KEY,
    Name VARCHAR(5) NOT NULL
);


CREATE TABLE Subject (
    ID INT PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);