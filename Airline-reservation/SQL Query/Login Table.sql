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

-- --------------------------------------------------------------------------------------------------------------------------------

-- Creating registered table that stores registerd users information
create table registered(
id int primary key identity,
fname varchar(20),
lname varchar(20),
email varchar(80),
phoneno varchar(15),
birthdate datetime,
gender char,
usrname varchar(20),
passwd varchar(20),
hintQ varchar(100),
hintA varchar(20),
profilepic image default NULL,
);

-- Initial Data to fill registerd table
Insert into registered(fname, lname, email, phoneno, birthdate, gender, usrname, passwd, hintQ, hintA)
values('Abebe','Kebede', 'abekebe@gmail.com', '0987654321', getdate(), 'M', 'abekebe', 'abekebe', 'Are you?', 'Yes');

select * from registered

drop table registered

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

-- --------------------------------------------------------------------------------------------------------------------------------
-- Booked Tickets table
