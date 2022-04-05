CREATE DATABASE TacoShop1;

go
use TacoShop1;
CREATE TABLE TacoShop1.dbo.Food(
	food_ID int NOT NULL,
	food_name nchar(10) NOT NULL,
	food_price money NOT NULL,
	PRIMARY KEY (food_ID)
	);
CREATE TABLE TacoShop1.dbo.Drink(
	drink_ID int NOT NULL,
	drink_name nchar(10) NOT NULL,
	drink_price money NOT NULL
	PRIMARY KEY (drink_ID)
);

Create TABLE TacoShop1.dbo.Receipt(
	receipt_ID int NOT NULL,
	customer_name nchar(20) null,
	choices varchar(50) null,
	tax money null,
	tip money null,
	full_price money null,
	PRIMARY KEY (receipt_ID)
);

INSERT INTO TacoShop1.dbo.Food (food_ID, food_name, food_price) 
VALUES (1,'Burrito', 3.50);

INSERT INTO TacoShop1.dbo.Food (food_ID, food_name, food_price) 
VALUES (2,'Taco', 1.50);

INSERT INTO TacoShop1.dbo.Drink (drink_ID, drink_name, drink_price) 
VALUES (1,'Water', 1.50);

INSERT INTO TacoShop1.dbo.Drink (drink_ID, drink_name, drink_price) 
VALUES (2,'Soda', 2.00);

INSERT INTO TacoShop1.dbo.Receipt(receipt_ID, customer_name, choices, tax, tip, full_price) VALUES (1, 'Thomas', 
'Burrito 3.50, Taco 1.50, 2x Water 1.50'
, 1.00, 1.00, 10.00);

INSERT INTO TacoShop1.dbo.Receipt(receipt_ID, customer_name, choices, tax, tip, full_price) VALUES (2, 'Morgan', 
'x3 Taco 1.50'
, .50, 1.00, 6);

INSERT INTO TacoShop1.dbo.Receipt(receipt_ID, customer_name, choices, tax, tip, full_price) VALUES (3, 'Tristan', 
'Taco 1.50, Water 1.50'
, 0.2, 3.00, 6.2);


INSERT INTO TacoShop1.dbo.Receipt(receipt_ID, customer_name, choices, tax, tip, full_price) VALUES (4, 'Riley', 
'x6 Soda 2.00'
, 1.5, 0.00, 13.5);


