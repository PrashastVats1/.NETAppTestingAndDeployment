select * from Employee
insert into Employee values (3, 'Sam', 'Dcosta', 77000.77,'Tester')

create proc usp_sEmployee
as
select Id as 'Employee ID', Fname as 'First Name', Lname as 'Last Name', Designation as 'Designation', Salary as 'Employee Salary'
from Employee

execute usp_sEmployee