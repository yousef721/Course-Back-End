-- 1) Create a table named "Employees" with columns for ID (integer), Name (varchar), and Salary (decimal).
CREATE TABLE Employees (
    ID INT,
    Name VARCHAR,
    salary DECIMAL
)
-- 2) Add a new column named "Department" to the "Employees" table with data type varchar(50).
ALTER TABLE Employees 
ADD Department VARCHAR(50)

-- 3) Remove the "Salary" column from the "Employees" table.
ALTER TABLE Employees
DROP COLUMN salary

-- 4) Rename the "Department" column in the "Employees" table to "DeptName".
EXEC sp_rename 'Employees.Department', 'DeptName', 'COLUMN'

-- 5) Create a new table called "Projects" with columns for ProjectID (integer) and ProjectName (varchar).
CREATE TABLE Projects (
    ProjectID INT,
    ProjectName VARCHAR(20)
)
-- 6) Add a primary key constraint to the "Employees" table for the "ID" column.
ALTER TABLE Employees
ALTER COLUMN ID INT NOT NULL

ALTER TABLE Employees 
ADD PRIMARY KEY(ID);

-- 7) Create a foreign key relationship between the "Employees" table (referencing "ID") and the "Projects" table (referencing "ProjectID").
ALTER TABLE Projects
ALTER COLUMN ProjectID INT NOT NULL

ALTER TABLE Projects
ADD PRIMARY KEY(ProjectID)

ALTER TABLE Employees 
ADD ProjectID INT FOREIGN KEY (ProjectID) REFERENCES Projects(ProjectID)

-- 8) Remove the foreign key relationship between "Employees" and "Projects."
ALTER TABLE Employees
DROP CONSTRAINT FK__Employees__Proje__4707859D

-- 9) Add a unique constraint to the "Name" column in the "Employees" table.
ALTER TABLE Employees 
ADD CONSTRAINT Unique_Name UNIQUE(Name)

-- 10) Create a table named "Customers" with columns for CustomerID (integer), FirstName (varchar), LastName (varchar), and Email (varchar), and Status (varchar).
CREATE TABLE Customers (
    CustomerID INT,
    FirstName VARCHAR,
    LastName VARCHAR,
    Email VARCHAR,
    Status VARCHAR
)
ALTER TABLE Customers
ALTER COLUMN CustomerID VARCHAR NOT NULL

ALTER TABLE Customers
ADD PRIMARY KEY(CustomerID)
-- 11) Add a unique constraint to the combination of "FirstName" and "LastName" columns in the "Customers" table.
ALTER TABLE Customers
ADD CONSTRAINT Unique_FirstName_Customer UNIQUE(FirstName)

ALTER TABLE Customers
ADD CONSTRAINT Unique_LastName_Customer UNIQUE(LastName)

-- 12) Add a default value of 'Active' for the "Status" column in the "Customers" table, where the default value should be applied when a new record is inserted.
ALTER TABLE Customers
ADD CONSTRAINT Status_default DEFAULT 'Active' FOR Status

-- 13) Create a table named "Orders" with columns for OrderID (integer), CustomerID (integer), OrderDate (datetime), and TotalAmount (decimal).
CREATE TABLE Orders (
    OrderID INT PRIMARY key,
    CustomerID INT,
    OrderDate DATETIME,
    TotalAmount DECIMAL,
)

-- 14) Add a check constraint to the "TotalAmount" column in the "Orders" table to ensure that it is greater than zero.
ALTER TABLE Orders 
ADD CHECK(TotalAmount > 0)

-- 15) Create a schema named "Sales" and move the "Orders" table into this schema.
CREATE SCHEMA Sales;

ALTER SCHEMA Sales TRANSFER dbo.Orders

-- 16) Rename the "Orders" table to "SalesOrders."
EXEC sp_rename 'Sales.Orders' , 'SalesOrders'
