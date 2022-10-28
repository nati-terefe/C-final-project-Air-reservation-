use AirlineReservation


-- Booked Tickets table


create table planes(
id int primary key identity(1000,1),
aircraft varchar(50) Not NUll,
totseat int Not NUll,
);

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

select * from planes

drop table planes

create table flights(
id int primary key IDENTITY(1010,1), 
dep varchar(30) Not NUll,
des varchar(30) Not NUll,
depdate datetime Not NUll,
pilot varchar(70) Not NUll unique,  
copilot varchar(70) Not NUll unique,
availseat int,
duration int,
planeref int FOREIGN KEY REFERENCES planes(id),
);

-- Initializing flights list
Insert into flights values('Addis Ababa', 'Dubai', '2022-05-26 03:14:00', 'Capt. Abebe Zeleke', 'Rediet Girum', 34, 3, 1000);
Insert into flights values('Addis Ababa', 'Dubai', '2022-06-26 02:14:00', 'Capt. Zerihun Zeleke','Abel Girum', 14, 3, 1001);
Insert into flights values('Addis Ababa', 'Istanbul', '2022-05-26 07:20:07', 'Capt. Abebe Haile','Bitaniya Damtew', 86, 7, 1002);
Insert into flights values('Addis Ababa', 'Istanbul', '2022-07-26 09:15:07', 'Capt. Zeleke Belay', 'Yonas Haile', 100, 7, 1003);
Insert into flights values('Addis Ababa', 'New York', '2022-06-26 09:20:00', 'Capt. Abebe Kebede', 'Ayub Girum', 120, 18, 1004);
Insert into flights values('Addis Ababa', 'New York', '2022-07-26 06:14:07', 'Capt. Kebedech Girum', 'Barkot Girum', 80, 18, 1005);
Insert into flights values('Addis Ababa', 'Paris', '2022-08-26 03:14:07', 'Capt. Tamrat Zewdee','Bereket Girum', 60, 12, 1006);
Insert into flights values('Addis Ababa', 'Paris', '2022-05-26 04:14:07', 'Capt. Eyob Nahom', 'Gemechu Girum', 50, 12, 1007);
Insert into flights values('Addis Ababa', 'Jakarta', '2022-06-26 01:14:07', 'Capt. Abel Yonas', 'Nuhamin Tarekeg', 340, 15, 1008);
Insert into flights values('Addis Ababa', 'Rome', '2022-08-26 02:14:07', 'Capt. Bamlak Kidus', 'Sofonias Michael', 1, 14, 1009);

select * from flights
SET IDENTITY_INSERT flights ON
drop table flights

CREATE OR ALTER FUNCTION flightexist(@flightid int)
returns int
as
begin
declare @exist int
select @exist=count(*) from flights where id=@flightid
return @exist
end

select dbo.flightexist(1010)


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
Insert into flights values(@dep,@des,@depdate,@pilot,@copilot,@availseat,@duration, @planeref);
END

select * from registered


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

CREATE OR ALTER PROCEDURE planeandnoofseat
(@flightid int,
@aircraft varchar(50) OUTPUT,
@totseat int OUTPUT
)
as
begin
select @totseat=totseat, @aircraft=aircraft from flights f join planes p on f.planeref=p.id where f.id=@flightid
end

