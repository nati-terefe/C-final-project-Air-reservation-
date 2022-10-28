use AirlineReservation -- Using AirlineReservation Databse

-- --------------------------------------------------------------------------------------------------------------------------------

-- Creating loginhistory table that stores login history information
create table loginhistory(
usrname varchar(20),
rol int,
timeanddate date,
registerationid int foreign key references registered(id),
);

-- Initial Data to fill login history table is done from C#

select * from loginhistory

drop table loginhistory

-- Stored Procedures for login history table --------------------------------------------------------------------------------------

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
Insert into loginhistory values(@usrname, @role , Getdate(), @refid);
END

execute addloginhistory 'user', 3;

select * from loginhistory

-- ------------------------------------------------------------------------------------

GO
-- 2. unlik login history and registration stored procedure 
--    that assign null to login history col of ref to full info when a record is deleted
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
-- 3. retrive login history stored procedure that retrive the entire login history

/*CREATE PROCEDURE addloginhistory(
@usrname varchar(20),
@role int
)
AS
BEGIN
Insert into loginhistory values(@usrname, @role , Getdate());
END

execute addloginhistory 'user',*/


-- --------------------------------------------------------------------------------------------------------------------------------
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
-- --------------------------------------------------------------------------------------------------------------------------------

GO
-- backupdb stored procedure that backup databse full or differential
CREATE OR ALTER PROCEDURE backupdb(
@full int,
@backuploc varchar(1000)
)
as
begin
DECLARE @backupdate varchar(30) 
DECLARE @backupname varchar(1000)
set @backupdate=FORMAT (getdate(), 'dd-mm-yyyy hh_mm_ss-tt')
if (@full=0)
	BEGIN
		SET @backuploc += '\Differential Airline Reservation System DB Backup - '
		SET @backupname=CONCAT(@backuploc, @backupdate, ' .bak')
		BACKUP DATABASE AirlineReservation
		TO DISK =  @backupname
		WITH DIFFERENTIAL;
	END
else if (@full=1)
	BEGIN
		SET @backuploc +='\Full Airline Reservation System DB Backup - '
		SET @backupname=CONCAT(@backuploc, @backupdate, '.bak')
		BACKUP DATABASE AirlineReservation
		TO DISK = @backupname
	END
END

Execute backupdb 0
Execute backupdb 1, 'C:\Users\redie\Desktop\Airline Reservation System Database Backup'
select getdate()