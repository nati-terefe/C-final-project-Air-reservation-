use AirlineReservation -- Using AirlineReservation Databse

-- --------------------------------------------------------------------------------------------------------------------------------

-- Creating planes table that stores planes information
create table planes(
id int primary key identity(1000,1),
aircraft varchar(50) Not NUll,
totseat int Not NUll,
);

-- Initial Datas to fill planes table
Insert into planes(aircraft, totseat) values('Boeing-777',400);
Insert into planes(aircraft, totseat) values('Boeing-737',300);
Insert into planes(aircraft, totseat) values('Boeing-767',400);
Insert into planes(aircraft, totseat) values('Boeing-777x',500);
Insert into planes(aircraft, totseat) values('Airbus-A330',300);
Insert into planes(aircraft, totseat) values('Airbus-A340',300);
Insert into planes(aircraft, totseat) values('Airbus-A350',400);
Insert into planes(aircraft, totseat) values('Airbus-A380',500);
Insert into planes(aircraft, totseat) values('Airbus-A444',500);
Insert into planes(aircraft, totseat) values('Airbus-A391',500);
Insert into planes(aircraft, totseat) values('Airbus-B61',300);
Insert into planes(aircraft, totseat) values('Airbus-B24',150);

select * from planes

drop table planes

-- ----------------------------------------------------------------------------------------------------------------
-- Procedure on planes table --------------------------------------------------------------------------------------
GO
-- ------------------------------------------------------------------------------------
-- 1. aircraft exist procedure that checks if an aircraft exists
CREATE or ALTER PROCEDURE aircraftexist(
@aircraft varchar(50),
@exist int OUTPUT
)
AS
BEGIN
select @exist=count(*) from planes where aircraft=@aircraft
END

declare @existance int
execute destexist 'abebe', @existance OUTPUT;
select @existance

GO
-- ------------------------------------------------------------------------------------
-- 2. what plane procedure that returns what plane a flight is using
CREATE OR ALTER PROCEDURE whatplane
(@flightid int,
@planeid int OUTPUT,
@aircraft varchar(50) OUTPUT,
@totseat int OUTPUT
)
as
begin
select @planeid=p.id, @totseat=totseat, @aircraft=aircraft from flights f join planes p on f.planeref=p.id where f.id=@flightid
end

-- --------------------------------------------------------------------------------------------------------------------------------
-- Function on planes table --------------------------------------------------------------------------------------
GO
-- 1. available planes function that creturns available planes unassociated with a flight 
CREATE OR ALTER FUNCTION availplanes()
RETURNS @availplanes TABLE ( 
id int,
aircraft varchar(50),
totseat int)
AS
Begin 
declare @temp table(
flightid varchar(20),
dep varchar(30),
planeid int,
aircraft varchar(50),
totseat int
)
Insert @temp
select ISNULL(f.id, 0), f.dep, p.id, p.aircraft, p.totseat from flights f right outer join planes p on f.planeref=p.id
Insert @availplanes
select planeid, aircraft, totseat from @temp where flightid=0
return
end;

select * from availplanes()

GO
-- ------------------------------------------------------------------------------------
-- 2. what no of seat function that returns total number of seat of an aircraft
CREATE FUNCTION whatnoofseat(
@planesid int)
RETURNS int
AS
begin
declare @noofseats int
select @noofseats=totseat from planes where id=@planesid
Return @noofseats
end

-- --------------------------------------------------------------------------------------------------------------------------------
-- --------------------------------------------------------------------------------------------------------------------------------

-- -- Creating pilots table that stores pilots information
create table pilots(
id int IDENTITY(101,1), 
full_name varchar(70) primary key not null,
flighthour int not null,
occupied int not null,
);

-- Initial data to  fill pilots table
Insert into pilots values('Capt. Abebe Zeleke', 1000,1);
Insert into pilots values('Rediet Girum', 750,1);
Insert into pilots values('Capt. Zerihun Zeleke', 1200,1);
Insert into pilots values('Abel Girum', 800, 1);
Insert into pilots values('Capt. Abebe Haile', 1100,1);
Insert into pilots values('Bitaniya Damtew', 900,1);
Insert into pilots values('Capt. Zeleke Belay', 1300,1);
Insert into pilots values('Yonas Haile', 900,1);
Insert into pilots values('Capt. Abebe Kebede', 1600,1);
Insert into pilots values('Ayub Girum', 600,1);
Insert into pilots values('Capt. Kebedech Girum', 1100,1);
Insert into pilots values('Barkot Girum', 900,1);
Insert into pilots values('Capt. Tamrat Zewdee', 1100,1);
Insert into pilots values('Bereket Girum', 900,1);
Insert into pilots values('Capt. Eyob Nahom', 1100,1);
Insert into pilots values('Gemechu Girum', 900,1);
Insert into pilots values('Capt. Abel Yonas', 1100,1);
Insert into pilots values('Nuhamin Tarekeg', 900,1);
Insert into pilots values('Capt. Bamlak Kidus', 1100,1);
Insert into pilots values('Sofonias Michael', 900,1);
-- Unoccupied pilots
Insert into pilots values('Capt. Zekarias Kebede', 1100,0);
Insert into pilots values('Lily Zegu', 900,0);
Insert into pilots values('Capt. Sinu Mohammed', 1100,0);
Insert into pilots values('Aljebar Alsayf', 900,0);
Insert into pilots values('Capt. Natanim Alemayew', 1100,0);
Insert into pilots values('Amanuel Kassaye', 900,0);

-- --------------------------------------------------------------------------------------------------------------------------------
-- Procedure on pilots table --------------------------------------------------------------------------------------
GO
-- 1. Pilot with flight procedure that returns pilots with the fights they're flying
CREATE or ALTER PROCEDURE pilotwithflight
AS
BEGIN
select * from pilots p left join flights f on f.pilot=p.full_name or f.copilot=p.full_name
END

-------------------------------------------------------------------------------

GO
-- 2. changeocuupations stored procedure changes occupied status of pilots
CREATE or alter procedure changeocuupations(
@pastpilot varchar(70),
@pastcopilot varchar(70),
@newpilot varchar(70),
@newcopilot varchar(70)
)
AS
BEGIN
update pilots
set occupied=0 where full_name=@pastpilot
update pilots
set occupied=0 where full_name=@pastcopilot
update pilots
set occupied=1 where full_name=@newpilot
update pilots
set occupied=1 where full_name=@newcopilot
END

-- --------------------------------------------------------------------------------------------------------------------------------
-- Function on pilots table --------------------------------------------------------------------------------------

GO
-- 1. availpilots return available or unoccupied pilots
CREATE Function availpilots()
returns  @availpilot TABLE ( 
id int, 
full_name varchar(70),
flighthour int,
occupied int)
AS
BEGIN
Insert @availpilot
select * from pilots where occupied=0
Return
END

-- --------------------------------------------------------------------------------------------------------------------------------
-- --------------------------------------------------------------------------------------------------------------------------------

-- -- Creating flights table that stores flights information
create table flights(
id int primary key IDENTITY(1010,1), 
dep varchar(30) Not NUll,
des varchar(30) Not NUll FOREIGN KEY REFERENCES destinations(city),
depdate datetime Not NUll,
pilot varchar(70) Not NUll FOREIGN KEY REFERENCES pilots(full_name),  
copilot varchar(70) Not NUll unique,
availseat int not null,
duration int not null,
planeref int FOREIGN KEY REFERENCES planes(id),
);

-- Initial Datas to fill flights table
Insert into flights values('Addis Ababa', 'UAE - Dubai', '2022-05-26 03:14:00', 'Capt. Abebe Zeleke', 'Rediet Girum', 34, 3, 1000);
Insert into flights values('Addis Ababa', 'UAE - Dubai', '2022-06-26 02:14:00', 'Capt. Zerihun Zeleke','Abel Girum', 14, 3, 1001);
Insert into flights values('Addis Ababa', 'Turkey - Istanbul', '2022-05-26 07:20:07', 'Capt. Abebe Haile','Bitaniya Damtew', 86, 7, 1002);
Insert into flights values('Addis Ababa', 'Turkey - Istanbul', '2022-07-26 09:15:07', 'Capt. Zeleke Belay', 'Yonas Haile', 100, 7, 1003);
Insert into flights values('Addis Ababa', 'USA - New York', '2022-06-26 09:20:00', 'Capt. Abebe Kebede', 'Ayub Girum', 120, 18, 1004);
Insert into flights values('Addis Ababa', 'USA - New York', '2022-07-26 06:14:07', 'Capt. Kebedech Girum', 'Barkot Girum', 80, 18, 1005);
Insert into flights values('Addis Ababa', 'France - Paris', '2022-08-26 03:14:07', 'Capt. Tamrat Zewdee','Bereket Girum', 60, 12, 1006);
Insert into flights values('Addis Ababa', 'France - Paris', '2022-05-26 04:14:07', 'Capt. Eyob Nahom', 'Gemechu Girum', 50, 12, 1007);
Insert into flights values('Addis Ababa', 'Indonesia - Jakarta', '2022-06-26 01:14:07', 'Capt. Abel Yonas', 'Nuhamin Tarekeg', 340, 15, 1008);
Insert into flights values('Addis Ababa', 'Italy - Rome', '2022-08-26 02:14:07', 'Capt. Bamlak Kidus', 'Sofonias Michael', 1, 14, 1009);

select * from flights

SET IDENTITY_INSERT flights ON

drop table flights

-- --------------------------------------------------------------------------------------------------------------------------------
-- Procedure on flights table --------------------------------------------------------------------------------------

GO
-- 1. Add flight procedure that adds a new flight onto flights table
CREATE or ALTER PROCEDURE addflight(
@dep varchar(30),
@des varchar(30),
@depdate datetime,
@pilot varchar(70),  
@copilot varchar(70),
@availseat int,
@duration int,
@planeref int
)
AS
BEGIN
Insert into flights values(@dep,@des,convert(datetime,@depdate,120),@pilot,@copilot,@availseat,@duration, @planeref);
END

GO
-- ------------------------------------------------------------------------------------
-- 2. update flight procedure that updates an existing flight in flights table
CREATE or ALTER PROCEDURE updateflight(
@flightid int,
@dep varchar(30),
@des varchar(30),
@depdate datetime,
@pilot varchar(70),  
@copilot varchar(70),
@availseat int,
@duration int,
@planeref int
)
AS
BEGIN
update flights
set dep=@dep, des=@des, depdate=convert(datetime,@depdate,120), pilot=@pilot, copilot=@copilot, availseat=@availseat, duration=@duration, planeref=@planeref where id=@flightid
END

GO
-- ------------------------------------------------------------------------------------
-- 3. Full flight info procedure that returns the full flight information of a ceratin flight id
CREATE or ALTER PROCEDURE fullflightinfo(
@flightid varchar(20),
@dep varchar(30) OUTPUT,
@des varchar(30) OUTPUT,
@depdate datetime OUTPUT,
@pilot varchar(70) OUTPUT,  
@copilot varchar(70) OUTPUT,
@availseat int OUTPUT,
@duration int OUTPUT,
@planeref int OUTPUT
)
AS
Begin
Select @dep=dep,@des=des,@depdate=depdate,@pilot=pilot,@copilot=copilot,@availseat=availseat,@duration=duration,@planeref=planeref
from flights where id=@flightid
End

GO
-- ------------------------------------------------------------------------------------
-- 4. Delete flight procedure that deletes full record of a flight
CREATE OR ALTER PROCEDURE deleteflight
(@flightid int)
as
begin
delete from flights where id=@flightid
end

GO
-- ------------------------------------------------------------------------------------
-- 5. Deptime match procedure that checks if selected dep time is a match with flight
CREATE OR ALTER PROCEDURE deptimematch
(@dest varchar(30), 
@deptime datetime,
@exist int OUTPUT)
as
begin
select @exist=count(*) from flights where des=@dest and depdate=convert(datetime,@deptime,120)
end

declare @exist int
execute deptimematch 'Indonesia - Jakarta', '2022-06-26 01:14:07', @exist OUTPUT
select @exist
select * from bookedtickets

-- ----------------------------------------------------------------------------------------------------------------
-- Function on flights table --------------------------------------------------------------------------------------

Go
-- 1. Flight exist function that checks if a flight exists 
CREATE OR ALTER FUNCTION flightexist(@flightid int)
returns int
as
begin
declare @exist int
select @exist=count(*) from flights where id=@flightid
return @exist
end

select dbo.flightexist(1010)

Go
-- 2. deptime function that returns departure time of a flight 
CREATE OR ALTER FUNCTION deptime(@dest varchar(30))
returns table
as
Return(select depdate from flights where des=@dest)

select * from deptime('UAE - Dubai')

Go
-- 3. how many hours function that returns duration of a flight 
CREATE OR ALTER FUNCTION howmanyhour(
@dest varchar(30),
@deptime datetime)
returns int
as
Begin
declare @hours int
select @hours=duration from flights where des=@dest and depdate=convert(datetime,@deptime,120)
Return @hours
end

select dbo.howmanyhour ('Indonesia - Jakarta', '2022-06-26 01:14:07')

-- 4. whatflightid that returns flight id based on dest and deptime 
CREATE OR ALTER FUNCTION whatflightid(
@dest varchar(30),
@deptime datetime)
returns int
as
Begin
declare @fid int
select @fid=id from flights where des=@dest and depdate=convert(datetime,@deptime,120)
Return @fid
end

select dbo.whatflightid ('Indonesia - Jakarta', '2022-06-26 01:14:07')

-- 5. availseats that returns availseat based on dest and deptime 
CREATE OR ALTER FUNCTION availseats(
@dest varchar(30),
@deptime datetime)
returns int
as
Begin
declare @availseat int
select @availseat=availseat from flights where des=@dest and depdate=convert(datetime,@deptime,120)
Return @availseat
end

select dbo.availseats ('Indonesia - Jakarta', '2022-06-26 01:14:07')

-- --------------------------------------------------------------------------------------------------------------------------------
-- --------------------------------------------------------------------------------------------------------------------------------

-- -- Creating destinations table that stores destination information
create table destinations(
id int Identity,
city varchar(30) not null primary key
);

-- Initializing destinations list
Insert into destinations values ('UAE - Dubai');
Insert into destinations values ('Turkey - Istanbul');
Insert into destinations values ('Indonesia - Jakarta');
Insert into destinations values ('USA - New York');
Insert into destinations values ('France - Paris');
Insert into destinations values ('Italy - Rome');

-- --------------------------------------------------------------------------------------------------------------------------------
-- Function on destination table --------------------------------------------------------------------------------------
GO
-- 1. destinations function that returns city of destination from destination table
CREATE OR ALTER FUNCTION dest()
RETURNS @destinations TABLE(
city varchar(50)
)
AS
begin
insert @destinations(city)
Select city from destinations
Return
end

-- --------------------------------------------------------------------------------------------------------------------------------
-- Procedure on destination table --------------------------------------------------------------------------------------
GO
-- 1. Destination exist procedure that checks if a destination exists
CREATE or ALTER PROCEDURE destexist(
@dest varchar(50),
@exist int OUTPUT
)
AS
BEGIN
select @exist=count(*) from destinations where city=@dest
END

declare @existance int
execute destexist 'abebe', @existance OUTPUT;
select @existance

-- --------------------------------------------------------------------------------------------------------------------------------
-- --------------------------------------------------------------------------------------------------------------------------------


