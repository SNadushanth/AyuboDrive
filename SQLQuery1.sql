create table Rent_Package
(
	Vehicle_No varchar(10),
	Vehicle_Type varchar(20),
	Daily_Rate int,
	Weekly_Rate int,
	Driver_Cost int,
	Monthly_Rate int,
)

create table Day_Package
(
	Package_No varchar(10),
	Vehicle_Type varchar(20),
	Package_Type varchar(20),
	Package_Rate int,
	Max_km int,
	Max_Hour int,
	Extra_kmRate int,
	Extra_Hourrates int,
)

create table Long_Package
(
	Package_No varchar(10),
	Vehicle_Type varchar(20),
	Package_Type varchar(20),
	Package_Rate int,
	Max_km int,
	Extra_kmRate int,
	Overnight_Cost int,
	Nightparking_Cost int,
)

create table Rented_Vehicle
(
	Rent_ID int IDENTITY PRIMARY KEY,
	Vehicle_Type varchar(20),
	Rented_Date date,
	Return_Date date,
	Driver_Status varchar(10),
	Total_Rent int,
)

create table Day_Hired
(
	Package_No varchar(10),
	Package_Type varchar(20),
	Start_km int,
	End_km int,
	Start_Time time,
	End_Time time,
	Basehire_Charge int,
	Waiting_Charge int,
	Extrakm_Charge int,
	Totalhire_Charge int,
)

create table Long_Hired
(
	Package_No varchar(10),
	Package_Type varchar(20),
	Start_Date date,
	End_Date date,
	Start_km int,
	End_km int,
	Basehire_Charge int,
	Overnight_Charge int,
	Extrakm_Charge int,
	Nightparking_Charge int,
	Totalhire_Charge int,
)

create table Login_Details
(	
	ID int IDENTITY PRIMARY KEY,
	Username varchar(50),
	Password varchar (20),
)

select * from Login_Details
select * from Day_Hired
select * from Day_Package
select * from Long_Hired
select * from Long_Package
select * from Rent_Package
select * from Rented_Vehicle

insert into Login_Details (Username,Password) values ('User','123');

drop table Login_Details;
drop table Day_Hired;
drop table Day_Package;
drop table Long_Hired;
drop table Long_Package;
drop table Rent_Package;
drop table Rented_Vehicle;