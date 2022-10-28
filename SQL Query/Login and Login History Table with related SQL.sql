create database AirlineReservation -- Creating Database

use AirlineReservation -- Using AirlineReservation Databse

-- --------------------------------------------------------------------------------------------------------------------------------

-- Creating login table that stores login information
create table login(
usrname varchar(20) not null unique,
passwd varchar(20) not null unique,
rol int not null,
registerationid int foreign key references registered(id),
);

-- Initial Datas to fill login table are done from C-Sharp by sign up

select * from login

drop table login

-- --------------------------------------------------------------------------------------------------------
-- Stored Procedures for login table ----------------------------------------------------------------------

GO
-- 1. What role stored procedure that returns the role of a certain usename and password
CREATE or ALTER PROCEDURE whatrole(
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
execute whatrole 'subadmin', 'subadmin', @role OUTPUT;
select @role

-- ------------------------------------------------------------------------------------

GO
-- 2. user exist stored procedure that returns the existance of a certain usename
CREATE or ALTER PROCEDURE userexist(
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

-- ------------------------------------------------------------------------------------

GO
-- 4. registrylogin stored procedure that creates a login for a register
CREATE or ALTER PROCEDURE registrylogin(
@usrname varchar(20),
@passwd varchar(20),
@rol int
)
AS
BEGIN
declare @refid int
select @refid=id from registered where usrname=@usrname
Insert into login values(@usrname, @passwd, @rol, @refid)
END

-- ------------------------------------------------------------------------------------

GO
-- 5. Set new password stored procedure that updates new password when forgot password
CREATE or ALTER PROCEDURE setnewpasswd(
@usrname varchar(20),
@newpasswd varchar(20)
)
AS
BEGIN
update login set passwd=@newpasswd where usrname=@usrname
END

execute setnewpasswd 'admin', 'admin';

select * from login

-- ------------------------------------------------------------------------------------

GO
-- 6. Set new role stored procedure that updates new role when role change
CREATE or Alter PROCEDURE setnewrole(
@usrname varchar(20),
@newrole int
)
AS
BEGIN
update login set rol=@newrole where usrname=@usrname
END

execute setnewrole 'subadmin', '2';

select * from login

-- --------------------------------------------------------------------------------------------------------------------------------
-- --------------------------------------------------------------------------------------------------------------------------------

-- Creating loginhistory table that stores login history information
create table loginhistory(
usrname varchar(20) not null,
rol int not null,
timeanddate datetime not null,
registerationid int foreign key references registered(id),
);

-- Initial Data to fill login history table is done from C#

select * from loginhistory

drop table loginhistory

-- ------------------------------------------------------------------------------------------------
-- Stored Procedures for login history table ------------------------------------------------------

GO
-- 1. add login history stored procedure that register new login history
CREATE or ALTER PROCEDURE addloginhistory(
@usrname varchar(20),
@role int
)
AS
BEGIN
declare @refid int
select @refid=id from registered where usrname=@usrname
Insert into loginhistory values(@usrname, @role , FORMAT (getdate(), 'yyyy-MM-dd HH:mm:ss'), @refid);
END

execute addloginhistory 'user', 3;

select * from loginhistory

-- ------------------------------------------------------------------------------------

GO
-- 2. unlink login history and registration stored procedure that assign null to login history col 
-- of ref to full info when a record is deleted this is a must since it has a reference with registered table
CREATE or ALTER PROCEDURE unlinkloginhisandreg(
@usrname varchar(20)
)
AS
BEGIN
update loginhistory
set registerationid=NULL where usrname=@usrname
END

execute unlinkloginhisandreg 'user'

select * from loginhistory

-- ------------------------------------------------------------------------------------

GO
-- 3. loginhisofusr procedure that returns loging history of certain username
CREATE or ALTER PROCEDURE loginhisofusr(
@usrname varchar(20)
)
AS
BEGIN
select * from loginhistory where usrname=@usrname
END

-- ------------------------------------------------------------------------------------

GO
-- 4. deleteregistrywithlogin stored procedure that deletes an entire record of certain username and sets login history ref to registered null
CREATE or ALTER PROCEDURE deleteregistrywithlogin(
@usrname varchar(20)
)
AS
BEGIN
update loginhistory 
set registerationid=null;
delete from login where usrname=@usrname
delete from registered where usrname=@usrname
END

-- ------------------------------------------------------------------------------------

GO
-- 5. update login history stored procedure that assign updated username when theres edit on username change
CREATE or ALTER PROCEDURE updateloginhis(
@initialusrname varchar(20),
@usrname varchar(20)
)
AS
BEGIN
declare @regid int
select @regid=id from registered where usrname=@usrname;
update loginhistory
set usrname=@usrname, registerationid=@regid where usrname=@initialusrname
END

