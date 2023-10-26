create database dbCompany26Oct2023

use dbCompany26Oct2023

create table Areas
(area varchar(20),
zipcode char(5))

sp_help Areas

alter table areas
alter column zipcode char(6) not null

alter table areas
add remarks varchar(100)

alter table areas
drop column remarks

drop table areas


create table Areas
(area varchar(20) constraint pk_area primary key,
zipcode char(5))

create table Employees
(employee_id int constraint pk_emp_id primary key,
name varchar(50),
age int,
area varchar(20) constraint fk_area foreign key references areas(area))

sp_help Employees

drop table Employees

create table Employees
(employee_id int identity(100,1) constraint pk_emp_id primary key,
name varchar(50) not null,
age int default 18,
area varchar(20) constraint fk_area foreign key references areas(area))

create table Skills
(skill varchar(20) constraint pk_skill primary key,
skill_description varchar(100))

sp_help skills

create table EmployeesSkills
(employee_id int constraint fk_emp_id foreign key references employees(employee_id),
skill_name varchar(20) constraint fk_skill foreign key references Skills(skill),
skill_level float,
constraint pk_emp_skill primary key(employee_id,skill_name))

sp_help EmployeesSkills
