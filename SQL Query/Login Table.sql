create database AirlineReservation -- Creating Database

use AirlineReservation -- Using Databse

-- --------------------------------------------------------------------------------------------------------------------------------

-- Creating login table that stores login information
create table login(
usrname varchar(20),
passwd varchar(20),
rol int,
hintQ varchar(100),
hintA varchar(20),
-- registerationid foreign key references registerd(id),
);

-- Initial Datas to fill login table
Insert into login values('admin','admin', 1, 'Are you the admin?', 'Yes');
Insert into login values('subadmin','subadmin', 2, 'Are you the subadmin?', 'Yes');
Insert into login values('user','user', 3, 'Are you the user?', 'Yes');

select * from login

drop table login

-- Stored Procedures for login table ----------------------------------------------------------------------------------------------
GO
-- 1. What role stored procedure that returns the role of a certain usename and password
CREATE or Alter PROCEDURE whatrole(
@usrname varchar(20),
@passwd varchar(20),
@roleis int OUTPUT
)
AS
BEGIN
if(EXISTS(select * from login where usrname=@usrname and passwd=@passwd))
	select @roleis=rol from login where usrname=@usrname and passwd=@passwd
else 
	set @roleis=0
END

declare @role int
execute whatrole 'admin', 'admin', @role OUTPUT;
select @role

GO
-- 2. user exist stored procedure that returns the existance of a certain usename
CREATE or Alter PROCEDURE userexist(
@usrname varchar(20),
@exist int OUTPUT
)
AS
BEGIN
select @exist=count(*) from login where usrname=@usrname
END

declare @existance int
execute userexist 'admin', @existance OUTPUT;
select @existance

GO
-- 3. What is the hint question stored procedure that returns the hint question of a certain usename and password
CREATE or Alter PROCEDURE whathintq(
@usrname varchar(20),
@hintqis varchar(100) OUTPUT
)
AS
BEGIN
select @hintqis=hintQ from login where usrname=@usrname
END

declare @hintq varchar(100)
execute whathintq 'admin', @hintq OUTPUT;
select @hintq

GO
-- 4. What is the hint answer stored procedure that returns the hint answer of a certain usename
CREATE or Alter PROCEDURE whathinta(
@usrname varchar(20),
@hintais varchar(20) OUTPUT
)
AS
BEGIN
select @hintais=hintA from login where usrname=@usrname
END

declare @hinta varchar(100)
execute whathinta 'admin', @hinta OUTPUT;
select @hinta

GO
-- 5. Set new password stored procedure that updates new password when forgot password
CREATE or Alter PROCEDURE setnewpasswd(
@usrname varchar(20),
@newpasswd varchar(20)
)
AS
BEGIN
update login set passwd=@newpasswd where usrname=@usrname
END

execute setnewpasswd 'admin', 'newadmin';

select * from login

GO
-- 3. registrylogin stored procedure that creates a login for register

CREATE or ALTER PROCEDURE registrylogin(
@usrname varchar(20),
@passwd varchar(20),
@rol int,
@hintQ varchar(100),
@hintA varchar(20)
)
AS
BEGIN
Insert into login values(@usrname, @passwd, @rol, @hintQ, @hintA)
END

select * from login

-- --------------------------------------------------------------------------------------------------------------------------------

-- Creating loginhistory table that stores login history information
create table loginhistory(
usrname varchar(20),
rol int,
timeanddate date,
);

-- Initial Data to fill login history table
Insert into loginhistory values('admin', 1, Getdate());

select * from loginhistory

drop table loginhistory

-- Stored Procedures for login history table --------------------------------------------------------------------------------------

GO
-- 1. add login history stored procedure that insert and register login history

CREATE PROCEDURE addloginhistory(
@usrname varchar(20),
@role int
)
AS
BEGIN
Insert into loginhistory values(@usrname, @role , Getdate());
END

execute addloginhistory 'user', 3;

GO
-- 2. retrive login history stored procedure that retrive the entire login history

/*CREATE PROCEDURE addloginhistory(
@usrname varchar(20),
@role int
)
AS
BEGIN
Insert into loginhistory values(@usrname, @role , Getdate());
END

execute addloginhistory 'user', 3;*/

-- --------------------------------------------------------------------------------------------------------------------------------

-- Creating registered table that stores registerd users information
create table registered(
id int primary key identity,
fname varchar(20),
lname varchar(20),
email varchar(80),
phoneno varchar(15),
birthdate datetime,
gender varchar(10),
usrname varchar(20),
passwd varchar(20),
hintQ varchar(100),
hintA varchar(20),
profilepic image default NULL,
);

-- Initial Data to fill registerd table
Insert into registered(fname, lname, email, phoneno, birthdate, gender, usrname, passwd, hintQ, hintA)
values('Abebe','Kebede', 'abekebe@gmail.com', '0987654321', getdate(), 'Male', 'abekebe', 'abekebe', 'Are you?', 'Yes');

select * from registered

drop table registered

-- Stored Procedures for registered table --------------------------------------------------------------------------------------

GO
-- 1. add new registry stored procedure that insert and register new user

CREATE or ALTER PROCEDURE addregistry(
@fname varchar(20),
@lname varchar(20),
@email varchar(80),
@phoneno varchar(15),
@birthdate datetime,
@gender varchar(10),
@usrname varchar(20),
@passwd varchar(20),
@hintQ varchar(100),
@hintA varchar(20),
@profilepic image
)
AS
BEGIN
Insert into registered(fname,lname,email,phoneno,birthdate,gender,usrname,passwd,hintQ,hintA,profilepic)
values(@fname,@lname,@email,@phoneno,@birthdate,@gender,@usrname,@passwd,@hintQ,@hintA,@profilepic);
END

select * from registered



-- --------------------------------------------------------------------------------------------------------------------------------

-- Creating contact messages table that stores users message information
create table contactmessages(
fname varchar(20),
lname varchar(20),
email varchar(80),
suggetion varchar(1000),
sugdate datetime
)

-- Initial Data to fill contactmessages table
Insert into contactmessages(fname, lname, email, suggetion, sugdate)
values('Abebe','Kebede', 'abekebe@gmail.com', 'I like It', getdate());

select * from contactmessages

drop table contactmessages

-- Stored Procedures for contactmessage table --------------------------------------------------------------------------------------

GO
-- 1. add message stored procedure that insert new message

CREATE or ALTER PROCEDURE addmessage(
@fname varchar(20),
@lname varchar(20),
@email varchar(80),
@suggetion varchar(1000)
)
AS
BEGIN
Insert into contactmessages(fname,lname,email,suggetion,sugdate)
values(@fname,@lname,@email,@suggetion,getdate());
END

select * from contactmessages

-- --------------------------------------------------------------------------------------------------------------------------------
-- Booked Tickets table
