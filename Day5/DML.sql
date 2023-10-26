insert into Areas(area,zipcode) values('ABC','12345')
--Primary key cannot be duplicated--
insert into Areas(area,zipcode) values('ABC','12345')
insert into Areas(area,zipcode) values('BBB','12345')
insert into Areas values('CCC','54321')
select * from Areas

insert into Skills values('C','PLT')
insert into Skills values('C++','OOPS'),('Java','Web'),('SQL','RDBMS')

select * from Skills

insert into Employees(name,age,area) values('Ramu',23,'ABC')
insert into Employees(name,age,area) values('Somu',34,'BBB'),('Bimu',27,'ABC')
--will not get inserted beacuse of volating refferntial integrity
insert into Employees(name,age,area) values('Ramu',23,'HHH')

select * from Employees

insert into EmployeesSkills values(101,'C',7)
insert into EmployeesSkills values(101,'C++',7)
insert into EmployeesSkills values(101,'Java',6)
insert into EmployeesSkills values(102,'Java',7)
insert into EmployeesSkills values(102,'SQL',8)
select * from EmployeesSkills

--change the skill level of 101 employee in c to 8
update EmployeesSkills set skill_level=8 where employee_id=101 and skill_name='c'

--update the age of employee Bimu to 29
update Employees Set age=29 where  name='Bimu'

--update name and age of employee 102
update Employees set name='Komu' ,age=22 where employee_id=102

--delete
delete from skills where skill = 'c'
--Delete from child to delete from parent
delete from EmployeesSkills where skill_name = 'c'
delete from skills where skill = 'c'