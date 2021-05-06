create database Final_Project

create table Employee
(
employee_ID varchar(30) not null unique default 'E-00',
employee_name char(30) not null,
address varchar(30) not null,
designation char(30) not null,
DOB varchar(30) not null default 'yyyy-mm-dd',
phone int not null unique,
CNIC varchar(15) not null unique default '00000-00000000-0',
department char(30) not null unique,
salary int not null,
primary key (employee_ID)
);

create table Affectee
(
Name char(30) not null,
CNIC varchar(30) not null default '00000-00000000-0',
Address char(30) not null,
dob date not null,
phone int not null unique,
service_availed char(30) not null,
serivce_availed_date date not null default getdate(),
primary key (CNIC),
employee_ID varchar(30) not null,
constraint employee_ID foreign key (employee_ID) references employee (employee_ID) on update cascade  on delete cascade 
);

create table Finance
(
total_amount int not null,
total_departments_budget int not null,
total_amount_left int not null,
date varchar(30) not null default 'mm/yy',
primary key (date)
);

create table Services
(
services_name char(30) not null,	
phone_number int not null unique,
number_of_employees int not null,
serviceID varchar(30) not null unique default 'S-00',
primary key (serviceID),
month_budget int not null,
budget_date varchar(30) not null,
constraint budget_date foreign key (budget_date) references finance (date) on update cascade on delete cascade
);

create table Ambulance_Service
(
Ambulance_Center_ID varchar (30) not null unique default 'A-00',
no_of_ambulances int not null,
primary key (Ambulance_Center_ID),
serviceID varchar(30) foreign key references Services(ServiceID) on update cascade on delete cascade
);

create table Hospital_Service
(
Hospital_ID varchar(30) not null unique default 'H-00',
service_provided char(30) not null,
patient_treated int not null,
address char(30) not null unique,
serviceID varchar(30) foreign key references Services(ServiceID) on update cascade on delete cascade
);

create table Education_Service
(
Education_Center_ID varchar(30) not null unique default 'Ed-00',
primary key(Education_Center_ID),
no_of_classroom int not null unique,
workshops_offered int not null,
no_of_std int not null,
serviceID varchar(30) foreign key references Services(ServiceID) on update cascade on delete cascade
);

create table Orphan_Homes
(
Orphan_home_ID varchar(30) not null unique default 'O-00',
no_orphan_child int not null,
address char(30) not null,
primary key (Orphan_home_ID),
serviceID varchar(30) foreign key references Services(ServiceID) on update cascade on delete cascade
);

create table Donor
(
donorID varchar(30) not null default 'D-00',
name char(30) not null,
address char(30) not null,
source_of_income char(30) not null,
donation_amount int not null,
date date not null,
primary key (donorID)
);

create table Funds
(
date varchar(30) not null default '[mm/yy]',
funds_collected int not null,
primary key (date),
donorID varchar(30) not null,
constraint donorID foreign key (donorID) references Donor (donorID)
);
