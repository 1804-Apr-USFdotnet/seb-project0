CREATE DATABASE Products;

USE Products
GO
CREATE TABLE Products (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] varchar(20) NOT NULL,
	Price FLOAT NOT NULL, CHECK (Price > 0)
);

CREATE TABLE Customers (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Firstname varchar(20) NOT NULL,
	Lastname varchar(20) NOT NULL,
	CardNumber varchar(16) NOT NULL, CHECK (DATALENGTH(CardNumber) = 16)
);

CREATE TABLE Orders (
	ID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ProductID INT NOT NULL FOREIGN KEY references Products(ID),
	CustomerID INT NOT NULL FOREIGN KEY references Customers(ID)
);

INSERT INTO Products ([Name], Price) VALUES ('iPhone', '200.00');
INSERT INTO Products ([Name], Price) VALUES ('Laptop', '550.00');
INSERT INTO Products ([Name], Price) VALUES ('Keyboard', '99.00');
INSERT INTO Products ([Name], Price) VALUES ('Monitor', '225.50');

INSERT INTO Customers (Firstname, Lastname, CardNumber) VALUES ('Tina', 'Smith', '1234987600001231');
INSERT INTO Customers (Firstname, Lastname, CardNumber) VALUES ('Jane', 'Doe', '9999100239841145');
INSERT INTO Customers (Firstname, Lastname, CardNumber) VALUES ('John', 'Dahmer', '1111222233334444');
INSERT INTO Customers (Firstname, Lastname, CardNumber) VALUES ('Michael', 'Myers', '7938174638594837');

INSERT INTO Orders (ProductID, CustomerID) VALUES (1, 1)
INSERT INTO Orders (ProductID, CustomerID) VALUES (1, 2)
INSERT INTO Orders (ProductID, CustomerID) VALUES (1, 3)
INSERT INTO Orders (ProductID, CustomerID) VALUES (2, 1)
INSERT INTO Orders (ProductID, CustomerID) VALUES (2, 3)
INSERT INTO Orders (ProductID, CustomerID) VALUES (4, 4)

SELECT Firstname, Lastname, Products.[Name]
FROM Customers
INNER JOIN Orders ON (Customers.ID = Orders.CustomerID)
INNER JOIN Products ON (Orders.ProductID = Products.ID)
WHERE (Customers.Firstname = 'Tina' AND Customers.Lastname = 'Smith')

SELECT SUM(Price)
FROM Products
WHERE ([Name] = 'iPhone')

UPDATE Products
SET Price = 250.00
WHERE ([Name] = 'iPhone')