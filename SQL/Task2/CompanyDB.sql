--CREATE DATABASE Company              

--USE Company                            

--CREATE TABLE Customer(                   
--ID int IDENTITY NOT NULL,
--[Name] varchar(20) NOT NULL,
--Surname varchar(20)  NULL,
--Salary float default 0 NULL
--)

--INSERT INTO Customer
--VALUES
--('Eli','Eliyev',500),
--('Veli','Veliyev',1000),
--('Aydin','Eliyev',985),
--('Gunay','Quliyeva',2200)

--SELECT * FROM Customer

--UPDATE  Customer
--SET Salary=1000 where ID=3

--DELETE Customer 
--where Salary=2200


--SELECT  Avg(Salary) AS OrtaMaash from Customer 

--SELECT [NAME],Salary FROM Customer 
--WHERE Salary >(Select AVG(Salary) from Customer)

--Select * from Customer
--Where Salary =(Select MAX(Salary) from Customer)

--Select * from Customer
--WHERE Salary =(Select MIN(Salary) from Customer)

--CREATE TABLE Position(
--ID INT IDENTITY NOT NULL primary key,
--[Name] varchar(20) 

--)

--ALTER TABLE Customer
--ADD  PositionID INT Null foreign key references Position(ID)
 
 
 --insert into Position 
 --values
 --('Junior programmr'),
 --('Middle programmr'),
 --('Senior programmer')

 --update Customer
 --set PositionID=1 where ID=1

 -- update Customer
 --set PositionID=2 where ID=2
 
 -- update Customer
 --set PositionID=3 where ID=3


 --select * from Customer

 --Select Customer.Name,Position.Name from Customer
 --Join Position
 --on Customer.PositionID=Position.ID

 

