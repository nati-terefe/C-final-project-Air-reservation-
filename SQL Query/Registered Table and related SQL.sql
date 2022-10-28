use AirlineReservation -- Using AirlineReservation Databse

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
profilepic image,
);

-- Initial Datas to fill registered table are done from C-Sharp by sign up

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

-- ------------------------------------------------------------------------------------

GO
-- 2. full info procedure returns full information of certain username
CREATE or ALTER PROCEDURE fullinfo(
@usrname varchar(20),
@fname varchar(20) OUTPUT,
@lname varchar(20) OUTPUT,
@email varchar(80) OUTPUT,
@phoneno varchar(15) OUTPUT,
@birthdate datetime OUTPUT,
@gender varchar(10) OUTPUT,
@passwd varchar(20) OUTPUT,
@hintQ varchar(100) OUTPUT,
@hintA varchar(20) OUTPUT,
)
AS
Begin
Select @fname=fname,@lname=lname,@email=email,@phoneno=phoneno,@birthdate=birthdate,@gender=gender,@passwd=passwd,@hintQ=hintQ,@hintA=hintA,
from registered where usrname=@usrname
End

select * from registered

-- ------------------------------------------------------------------------------------

GO
-- 3. updateregistry procedure updates registry information of certain user
CREATE or ALTER PROCEDURE updateregistry(
@initialusrname varchar(20),
@usrname varchar(20),
@fname varchar(20),
@lname varchar(20),
@email varchar(80),
@phoneno varchar(15),
@birthdate datetime,
@gender varchar(10),
@passwd varchar(20),
@hintQ varchar(100),
@hintA varchar(20),
@profilepic image
)
AS
Begin
update registered 
set fname=@fname,lname=@lname,email=@email,phoneno=@phoneno,birthdate=@birthdate,gender=@gender,passwd=@passwd,hintQ=@hintQ,hintA=@hintA,profilepic=@profilepic
where usrname=@initialusrname
End

select * from registered

-- ------------------------------------------------------------------------------------

GO
-- 4. deleteregistrywithlogin stored procedure that deletes an entire record of certain username
CREATE or ALTER PROCEDURE deleteregistrywithlogin(
@usrname varchar(20)
)
AS
BEGIN
delete from login where usrname=@usrname
delete from registered where usrname=@usrname
END

select * from login
select * from registered

-- ------------------------------------------------------------------------------------

GO
-- 5. What is the hint question stored procedure that returns the hint question of a certain usename and password
CREATE or ALTER PROCEDURE whathintq(
@usrname varchar(20),
@hintqis varchar(100) OUTPUT
)
AS
BEGIN
select @hintqis=hintQ from registered where usrname=@usrname
END

declare @hintq varchar(100)
execute whathintq 'admin', @hintq OUTPUT;
select @hintq

-- ------------------------------------------------------------------------------------

GO
-- 6. What is the hint answer stored procedure that returns the hint answer of a certain usename
CREATE or ALTER PROCEDURE whathinta(
@usrname varchar(20),
@hintais varchar(20) OUTPUT
)
AS
BEGIN
select @hintais=hintA from registered where usrname=@usrname
END

declare @hinta varchar(100)
execute whathinta 'admin', @hinta OUTPUT;
select @hinta

-- --------------------------------------------------------------------------------------------------------------------------------
-- Function on registered table --------------------------------------------------------------------------------------
GO
-- 1. What photo function returns photo of certain username
CREATE or ALTER FUNCTION whatphoto(
@usrname varchar(20)
)
returns table
AS
Return(
Select profilepic from registered where usrname=@usrname
)

select * from whatphoto( 'miky' )