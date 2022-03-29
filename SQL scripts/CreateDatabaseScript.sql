CREATE DATABASE TacoShop1;

go
use TacoShop1;
CREATE TABLE TacoShop1.dbo.Food(
	food_name nchar(10),
	food_price money
	);
CREATE TABLE TacoShop1.dbo.Drink(
	drink_name nchar(10),
	drink_price money
);

Create TABLE TacoShop1.dbo.Receipt(
	receipt_ID int null,
	customer_name nchar(20) null,
	choices varchar(50) null,
	tax money null,
	tip money null,
	full_price money null
);

INSERT INTO TacoShop1.dbo.Food (food_name, food_price) 
VALUES ('Burrito', 21);

INSERT INTO TacoShop1.dbo.Food (food_name, food_price) 
VALUES ('Taco', 1.50);

INSERT INTO TacoShop1.dbo.Drink (drink_name, drink_price) 
VALUES ('Water', 1.50);

INSERT INTO TacoShop1.dbo.Drink (drink_name, drink_price) 
VALUES ('Soda', 2.00);

INSERT INTO TacoShop1.dbo.Receipt(receipt_ID, customer_name, choices, tax, tip, full_price) VALUES (1, 'Thomas', 
(Select STRING_AGG( ISNULL((food_name), ' '), ',') as receipt from Food)
, 0.03, 1.00, 5.00);

INSERT INTO TacoShop1.dbo.Receipt(receipt_ID, customer_name, choices, tax, tip, full_price) VALUES (2, 'Riley', 
(Select STRING_AGG( ISNULL((drink_name), ' '), ',') as receipt from Drink)
, 0.04, 12.00, 11.00);


