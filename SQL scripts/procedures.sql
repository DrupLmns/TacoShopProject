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