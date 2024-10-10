USE Test;
CREATE TABLE Customers
(CustomerID int,
FirstName varchar(255),
LastName varchar(255),
City varchar(255),
State varchar(255)
);

INSERT INTO Customers(CustomerID, FirstName,LastName, City, State)
VALUES('1', 'Adhyatm','Mishra','Mumbai','Maharashtra'),
('2','Anisha','Kabeer','Coimbatore','Tamil Nadu'),
('3','Purva','Patil','Indore','Madhya Pradesh'),
('4','Sejal','Shah','Ahmedabad','Gujarat');

--1
SELECT FirstName
FROM Customers
ORDER BY FirstName DESC;

--2
SELECT City, FirstName, LastName
From Customers
ORDER BY City, FirstName;

--8
SELECT FirstName
FROM Customers
WHERE FirstName LIKE '[A-C]%';

--9
SELECT FirstName
FROM Customers
WHERE FirstName NOT LIKE 'A%';

--10
SELECT State, City, COUNT(CustomerID) AS number_of_customers
FROM Customers
GROUP BY State, City
ORDER BY State, City;
 


USE Test;
CREATE TABLE Products
(CustomerID int,
ProductName varchar(255),
ModelYear tinyint,
ListPrice decimal(10,2)
);

INSERT INTO Products(CustomerID, ProductName,ModelYear, ListPrice)
VALUES('1', 'Smartphone', '2018','299.99'),
('2','Tablet','2017','489.99'),
('3','Laptop','2019','5000.99'),
('4','Washmachine','2020','3000.45');

ALTER TABLE Products
ALTER COLUMN ModelYear SMALLINT;

SELECT * FROM Products;

--3
SELECT ProductName, ListPrice AS ExpensiveProducts
FROM Products
ORDER BY ListPrice DESC;

--4
SELECT * 
FROM Products 
WHERE ListPrice > 200 AND ModelYear = 2018;

--5
SELECT * 
FROM Products 
WHERE ListPrice > 300 OR ModelYear = 2018;

--6
SELECT * 
FROM Products 
WHERE ListPrice  BETWEEN 1899 AND 4999.99;

--7
SELECT *
FROM Products
WHERE ListPrice IN (299.99, 466.99, 489.99);

ALTER TABLE Products
ADD OrdersPlaced int;

INSERT INTO Products(OrdersPlaced)
VALUES('40'),
('99'),
('50'),
('200');

UPDATE Products
SET OrdersPlaced = '50'
WHERE CustomerID = '1';

UPDATE Products
SET OrdersPlaced = '60'
WHERE CustomerID = '2';

UPDATE Products
SET OrdersPlaced = '70'
WHERE CustomerID = '3';

UPDATE Products
SET OrdersPlaced = '200'
WHERE CustomerID = '4';

SELECT OrdersPlaced
FROM Customers
GROUP BY CustomerID, ModelYear;

DELETE FROM Products WHERE OrdersPlaced='40';
DELETE FROM Products WHERE OrdersPlaced='99';
DELETE FROM Products WHERE OrdersPlaced='50';
DELETE FROM Products WHERE OrdersPlaced='200';
SELECT * FROM Products;

INSERT INTO Products(CustomerID, ProductName,ModelYear, ListPrice, OrdersPlaced)
VALUES('4', 'Smartphone', '2018','299.99', '300'),
('5','Washmachine','2020','3000.45', '800');

SELECT ProductName
FROM Products
GROUP BY CustomerID, ModelYear;

--12

CREATE TABLE Categories (
  CategoryID INT PRIMARY KEY
);

ALTER TABLE Products
ADD CategoryID INT;
ALTER TABLE Products
ADD CONSTRAINT FK_Products_Categories
FOREIGN KEY (CategoryID) REFERENCES Categories (CategoryID);