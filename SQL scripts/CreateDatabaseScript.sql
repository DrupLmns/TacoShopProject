go
DROP DATABASE IF EXISTS TacoShop;
go
CREATE DATABASE TacoShop;

go
use TacoShop;
CREATE TABLE TacoShop.dbo.Employees(
	Employee_ID int NOT NULL,
	Employee_Name nchar(10) NOT NULL,
	Employee_Username nvarchar(50) NOT NULL,
	Employee_Password nvarchar(128) NOT NULL,
	IsAdmin int NOT NULL,
	PRIMARY KEY (Employee_ID)
);

CREATE TABLE TacoShop.dbo.Item(
	item_ID int NOT NULL,
	item_name nchar(10) NOT NULL,
	item_price money NOT NULL,
	PRIMARY KEY (item_ID)
	);

Create TABLE TacoShop.dbo.Receipt(
	receipt_ID int NOT NULL,
	customer_name nchar(20) null,
	choices varchar(50) null,
	tax money null,
	tip money null,
	full_price money null,
	PRIMARY KEY (receipt_ID)
);
INSERT INTO TacoShop.dbo.Employees(Employee_ID,Employee_Name,Employee_Username,Employee_Password, IsAdmin)
Values ( 1, 'James','jamie01', '6ca13d52ca70c883e0f0bb101e425a89e8624de51db2d2392593af6a84118090', 1 )
									--abc123													 --true
INSERT INTO TacoShop.dbo.Employees(Employee_ID,Employee_Name,Employee_Username,Employee_Password, IsAdmin)
Values ( 1, 'Maggie','HomerSimpson420', 'ede7d1a08219bc413487044028f2c640d4c29bc4f68c79013a29575286a7a30a', 0 )

INSERT INTO TacoShop.dbo.Item (item_ID, item_name, item_price) 
VALUES (1,'Burrito', 3.50);

INSERT INTO TacoShop.dbo.Item (item_ID, item_name, item_price) 
VALUES (2,'Taco', 1.50);

INSERT INTO TacoShop.dbo.Item (item_ID, item_name, item_price) 
VALUES (3,'Water', 1.50);

INSERT INTO TacoShop.dbo.Item (item_ID, item_name, item_price) 
VALUES (4,'Soda', 2.00);

INSERT INTO TacoShop.dbo.Receipt(receipt_ID, customer_name, choices, tax, tip, full_price) VALUES (1, 'Thomas', 
'Burrito 3.50,Taco 1.50,2x Water 1.50'
, 1.00, 1.00, 10.00);

INSERT INTO TacoShop.dbo.Receipt(receipt_ID, customer_name, choices, tax, tip, full_price) VALUES (2, 'Morgan', 
'x3 Taco 1.50'
, .50, 1.00, 6);

INSERT INTO TacoShop.dbo.Receipt(receipt_ID, customer_name, choices, tax, tip, full_price) VALUES (3, 'Tristan', 
'Taco 1.50,Water 1.50'
, 0.2, 3.00, 6.2);


INSERT INTO TacoShop.dbo.Receipt(receipt_ID, customer_name, choices, tax, tip, full_price) VALUES (4, 'Riley', 
'x6 Soda 2.00'
, 1.5, 0.00, 13.5);

--
-- PROCEDURES
--
go

use TacoShop
go
create or alter procedure getTaco
as
select * from Item where item_name = 'Taco'
return
go

create or alter procedure getBurrito
as
select * from Item where item_name = 'Burrito'
return

go
create or alter procedure getWater
as
select * from Item where item_name = 'Water'
return

go
create or alter procedure getSoda
as
select * from Item where item_name = 'Soda'
return

go 
create or alter procedure getReceipts
as
select * from Receipt
return

go
create or alter procedure lookupReceiptID @receiptID int
as
	IF EXISTS (Select * from Receipt where receipt_ID = @receiptID)
	BEGIN
		Select * from Receipt where receipt_ID = @receiptID
	END
	ELSE
	BEGIN
		Return -1;
	END
return

go
create or alter procedure lookupReceiptName @receiptName nchar(20)
as
	IF EXISTS (Select * from Receipt where customer_name = @receiptName)
	BEGIN
		Select * from Receipt where customer_name = @receiptName
	END

	ELSE
	BEGIN
		Return -1;
	END
return

go
create or alter procedure EmployeeLogin @username nchar(50), @password nchar(128)
as
	IF EXISTS (Select * from Employees where Employee_Username = @username and Employee_Password = @password)
	BEGIN
		Select * from Employees where Employee_Username = @username and Employee_Password = @password
	END
	else
	BEGIN
		return -1
	END
return

go
create or alter procedure CreateEmployee
@Employee_ID int,
@Employee_Name nchar(50),
@username nchar(50), 
@password nchar(128),
@IsAdmin int
as
INSERT INTO TacoShop.dbo.Employees(Employee_ID,Employee_Name,Employee_Username,Employee_Password, IsAdmin)
Values ( @Employee_ID, @Employee_Name,@username, @password, @IsAdmin )
return

go
create or alter procedure CreateReceipt
@ID int,
@Name nchar(50),
@choices varchar(50), 
@tax money,
@tip money,
@finaltotal money
as
insert into TacoShop.dbo.Receipt(receipt_ID, customer_name, choices, tax, tip, full_price) 
values(@ID, @Name, @choices, @tax, @tip, @finaltotal)
return

