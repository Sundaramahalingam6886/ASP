create database company
use company

create table auditor(id int primary key, name varchar(30), passwrd varchar(20), Desig varchar(20), city varchar(30), salary money, gender varchar(20), age int) 
drop table auditor
select * from auditor
update auditor set Desig='Auditor'
