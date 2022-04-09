go
DROP DATABASE IF EXISTS TacoShop;
go
CREATE DATABASE TacoShop;

go
use TacoShop;
CREATE TABLE TacoShop.dbo.Food(
	food_ID int NOT NULL,
	food_name nchar(10) NOT NULL,
	food_price money NOT NULL,
	PRIMARY KEY (food_ID)
	);
CREATE TABLE TacoShop.dbo.Drink(
	drink_ID int NOT NULL,
	drink_name nchar(10) NOT NULL,
	drink_price money NOT NULL
	PRIMARY KEY (drink_ID)
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

INSERT INTO TacoShop.dbo.Food (food_ID, food_name, food_price) 
VALUES (1,'Burrito', 3.50);

INSERT INTO TacoShop.dbo.Food (food_ID, food_name, food_price) 
VALUES (2,'Taco', 1.50);

INSERT INTO TacoShop.dbo.Drink (drink_ID, drink_name, drink_price) 
VALUES (1,'Water', 1.50);

INSERT INTO TacoShop.dbo.Drink (drink_ID, drink_name, drink_price) 
VALUES (2,'Soda', 2.00);

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
select * from Food where food_name = 'Taco'
return
go

create or alter procedure getBurrito
as
select * from Food where food_name = 'Burrito'
return

go
create or alter procedure getWater
as
select * from Drink where drink_name = 'Water'
return

go
create or alter procedure getSoda
as
select * from Drink where drink_name = 'Soda'
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