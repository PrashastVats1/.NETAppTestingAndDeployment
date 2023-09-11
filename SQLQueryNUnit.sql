create database ProductDb
use ProductDb

create table Product
(Id int primary key identity,
Name nvarchar(50) not null,
Price float not null)
insert into Product values ('Kindle Book',5500.50)
insert into Product values ('Nothing Phone-2',48845.56)
insert into Product values ('Boat Earbuds',3000.45)
select * from Product