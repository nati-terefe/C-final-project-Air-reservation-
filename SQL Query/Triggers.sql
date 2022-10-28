use AirlineReservation

-- --------------------------------------------------------------------------------------------------------------------------------
GO
-- 1. formatregistration to correctly capitalize registration input
CREATE OR ALTER TRIGGER formatregistration
ON registered
After insert
AS
BEGIN
Declare @fname varchar(20)
Declare @lname varchar(20)
Declare @lastid int
select @lastid=max(id) from registered
select @fname=i.fname, @lname=i.lname from inserted i
select @fname=STUFF(@fname,1,1,Upper(substring(@fname,1,1)))
select @lname=STUFF(@lname,1,1,Upper(substring(@lname,1,1)))
update registered
set fname=@fname, lname=@lname where id=@lastid
END

-- --------------------------------------------------------------------------------------------------------------------------------
GO
-- 2. bookingexist to check not to create multiple booking for same person and if itsn't multiple to decrease availseat on flights
CREATE OR ALTER TRIGGER bookingexist
ON bookedtickets
After insert
AS
BEGIN
Declare @id int
Declare @passport varchar(20)
Declare @dest varchar(30)
Declare @depdate datetime
declare @exist int=0
Declare @fidref int
select @id=i.id, @dest=i.dest, @depdate=i.depdate, @passport=i.passport, @fidref=i.fidref from inserted i
select @exist=count(*) from bookedtickets where dest=@dest and depdate=@depdate and passport=@passport
if(@exist>1)
	BEGIN
		delete from bookedtickets where id=@id and dest=@dest and depdate=@depdate and passport=@passport
	END
else
	BEGIN
		update flights 
		set availseat=availseat-1 where id=@fidref
	END
END

-- --------------------------------------------------------------------------------------------------------------------------------

GO
-- 3. delflightticket that delete booked tickets on flight
CREATE OR ALTER TRIGGER delflightticket
ON flights
After delete
AS
BEGIN
Declare @fid int
select @fid=d.id from deleted d
delete from bookedtickets where fidref=@fid
END

-- --------------------------------------------------------------------------------------------------------------------------------

GO
-- 4. unique pilot check if a pilot is not flying another flight
CREATE OR ALTER TRIGGER ispilotoccupied
ON flights
After insert
AS
BEGIN
declare @occupiedp int
declare @occupiedc int
declare @pilot varchar(70)
declare @copilot varchar(70)
select @pilot=i.pilot from inserted i
select @copilot=i.copilot from inserted i
select @occupiedp=p.occupied from pilots p where full_name=@pilot
select @occupiedc=p.occupied from pilots p where full_name=@copilot
if(@occupiedp=1 OR @occupiedc=1)
	ROLLBACK TRANSACTION;
else
	BEGIN
		update pilots
		set occupied=1 where full_name=@pilot
		update pilots
		set occupied=1 where full_name=@copilot
	END
END

-- --------------------------------------------------------------------------------------------------------------------------------

GO
-- 5. unoccupypilot changes ocuppied status of a pilot when flight deleted
CREATE OR ALTER TRIGGER unoccupypilot
ON flights
After delete
AS
BEGIN
declare @pilot varchar(70)
declare @copilot varchar(70)
select @pilot=d.pilot from deleted d
select @copilot=d.copilot from deleted d
update pilots
set occupied=0 where full_name=@pilot
update pilots
set occupied=0 where full_name=@copilot
END

-- --------------------------------------------------------------------------------------------------------------------------------

GO
-- 6. updateticketbasedonflight that updates booked tickets based on change on flight
CREATE OR ALTER TRIGGER updateticketbasedonflight
ON bookedtickets
After update
AS
BEGIN
Declare @depdate datetime
Declare @dest varchar(30)
Declare @id int
select @depdate=depdate from inserted i
select @dest=dest from inserted i
select @id=id from inserted i
update bookedtickets
set depdate=@depdate, dest=@dest where fidref=@id
END

-- --------------------------------------------------------------------------------------------------------------------------------





