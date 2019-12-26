Create database BDCoffeeShopBD
USE BDCoffeeShopBD

CREATE TABLE Items(
ItemId INT IDENTITY(1,1) PRIMARY KEY,
ItemName VARCHAR(50),
ItemPrice DOUBLE PRECISION
)

INSERT INTO Items (ItemName, ItemPrice) Values ('Black Coffee', 120.00)
INSERT INTO Items (ItemName, ItemPrice) Values ('Regular Coffee', 80.00)
INSERT INTO Items (ItemName, ItemPrice) Values ('Cold Coffee', 100.00)
INSERT INTO Items (ItemName, ItemPrice) Values ('Hot Coffee', 90.00)

CREATE TABLE Customers(
CustomerId INT IDENTITY(1,1) PRIMARY KEY,
CustomerName VARCHAR(50),
[Address] VARCHAR(200),
Contact VARCHAR(50),
)

INSERT INTO Customers (CustomerName, [Address], Contact) VALUES ('Ali', 'Dhaka' ,'01311369369')
INSERT INTO Customers (CustomerName, [Address], Contact) VALUES ('Hasan', 'Sylhet' ,'01711369369')
INSERT INTO Customers (CustomerName, [Address], Contact) VALUES ('Rafi', 'BNorisal' ,'01811369369')

SELECT * FROM Items
SELECT * FROM Customers
Select * FROM Orders

CREATE TABLE Orders(
OrdersId INT IDENTITY(1,1) PRIMARY KEY,
CustomersId INT FOREIGN KEY REFERENCES Customers(CustomerId),
ItemsId INT FOREIGN KEY REFERENCES Items(ItemId),
Customer VARCHAR(100),
Item VARCHAR(50),
Quantity INT,
TotalPrice DOUBLE PRECISION
)

DROP TABLE Orders

	--INSERT INTO Orders (CustomersId, ItemsId, Quantity, TotalPrice) VALUES (1, 1, 5, 600)
	--INSERT INTO Orders (CustomersId, ItemsId, Quantity, TotalPrice) VALUES (1, 2, 3, 240)
	--INSERT INTO Orders (CustomersId, ItemsId, Quantity, TotalPrice) VALUES (1, 3, 2, 200)

	--INSERT INTO Orders (CustomersId, ItemsId, Quantity, TotalPrice) VALUES (2, 2, 2, 160)
	--INSERT INTO Orders (CustomersId, ItemsId, Quantity, TotalPrice) VALUES (2, 3, 3, 300)
	--INSERT INTO Orders (CustomersId, ItemsId, Quantity, TotalPrice) VALUES (2, 4, 4, 400)

	--INSERT INTO Orders (CustomersId, ItemsId, Quantity, TotalPrice) VALUES (3, 2, 2, 160)
	--INSERT INTO Orders (CustomersId, ItemsId, Quantity, TotalPrice) VALUES (3, 1, 3, 300)
	--INSERT INTO Orders (CustomersId, ItemsId, Quantity, TotalPrice) VALUES (3, 3, 4, 400)

CREATE VIEW OrdersDetailView
AS
SELECT o.OrdersId, CustomersId, CustomerName, ItemId, ItemName, Quantity, ItemPrice, TotalPrice FROM Orders AS o 
LEFT JOIN Customers AS c ON c.CustomerId = o.CustomersId 
LEFT JOIN Items AS i ON i.ItemId = o.ItemsId

SELECT * FROM OrdersDetailsView

CREATE VIEW OrderDetailView
AS
SELECT o.OrdersId, CustomersId, CustomerName, Quantity, TotalPrice FROM Orders AS o 
LEFT JOIN Customers AS c ON c.CustomerId = o.CustomersId

SELECT * FROM OrderDetailsView
