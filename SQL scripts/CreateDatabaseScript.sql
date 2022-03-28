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

INSERT INTO TacoShop1.dbo.Food (food_name, food_price) 
VALUES ('Burrito', 21);

INSERT INTO TacoShop1.dbo.Food (food_name, food_price) 
VALUES ('Taco', 1.50);

INSERT INTO TacoShop1.dbo.Drink (drink_name, drink_price) 
VALUES ('Water', 1.50);

INSERT INTO TacoShop1.dbo.Drink (drink_name, drink_price) 
VALUES ('Soda', 2.00);