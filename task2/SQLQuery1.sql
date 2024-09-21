
--1. Write an SQL query to retrieve the names and emails of all customers. 
USE TechShop1
SELECT FirstName, LastName, Email
From Customers;

--2. Write an SQL query to list all orders with their order dates and corresponding customer names
SELECT O.OrderID, O.OrderDate, C.FirstName, C.LastName
FROM Orders O
JOIN Customers C ON O.CustomerID = C.CustomerID;

-- 3. Write an SQL query to insert a new customer record into the "Customers" table. Include 
--customer information such as name, email, and address.

INSERT INTO Customers (FirstName, LastName, Email, Phone, Address)
VALUES ('Mark', 'Jones', 'mark.jones@example.com', '5551234567', '789 Willow St');
SELECT * FROM Customers;

--4.update the prices of all electronic gadgets in the "Products" table by 
--increasing them by 10%.

UPDATE Products
SET Price = Price * 1.10 
WHERE ProductName = 'Laptop';
SELECT * FROM Products;

--5.  delete a specific order and its associated order details from the 
--"Orders" and "OrderDetails" tables. Allow users to input the order ID as a parameter. 
DELETE FROM Orders WHERE OrderID = '5'
DELETE FROM OrderDetails WHERE OrderID = '5'
SELECT * FROM Orders;

--6.insert a new order into the "Orders" table. Include the customer ID, 
--order date, and any other necessary information.
INSERT INTO Orders (CustomerID, OrderDate, TotalAmount)
VALUES (11, GETDATE(), 199.99);  
SELECT * FROM Orders;

--7.update the contact information (e.g., email and address) of a specific 
--customer in the "Customers" table. Allow users to input the customer ID and new contact 
--information.
UPDATE Customers
SET Email = 'p@gmail.com', Address = 'Mars' , Phone = '20202' WHERE CustomerID ='4';
SELECT * FROM Customers;

--8.recalculate and update the total cost of each order in the "Orders" 
--table based on the prices and quantities in the "OrderDetails" table.
UPDATE Orders 
SET TotalAmount = (
    SELECT SUM(OD.Quantity * Orders.TotalAmount)
    FROM OrderDetails OD
    WHERE OD.OrderID = Orders.OrderID
);

SELECT TotalAmount FROM Orders;

--9.delete all orders and their associated order details for a specific 
--customer from the "Orders" and "OrderDetails" tables. Allow users to input the customer ID 
--as a parameter.
DELETE FROM Orders WHERE OrderID=1;

-- 10. Insert a New Electronic Gadget Product into the "Products" Table
INSERT INTO Products (ProductName, Description, Price )
VALUES ('Smart TV', '55-inch 4K Smart TV', 599.99);
SELECT * FROM Products;

-- 11th and 12th query solution I wasn't able to solve mam