CREATE DATABASE HR

USE HR

-- Table Regions
CREATE TABLE Regions (
    Region_ID NUMERIC PRIMARY KEY,
    Region_Name VARCHAR(25),
)

-- Table Countries
CREATE TABLE Countries (
    Country_ID CHAR(2) PRIMARY KEY,
    Country_Name VARCHAR(40),
    Region_ID NUMERIC FOREIGN KEY REFERENCES Regions(Region_ID)
)

-- Table Locations
CREATE TABLE Locations (
    Location_ID NUMERIC PRIMARY KEY,
    Street_Address VARCHAR(25),
    Postal_Code VARCHAR(25),
    City VARCHAR(25),
    State_Prince VARCHAR(25),
    Country_ID CHAR(2) FOREIGN KEY REFERENCES Countries(Country_ID),
)

-- Table Departments
CREATE TABLE Departments (
    Department_ID NUMERIC PRIMARY KEY,
    Department_Name VARCHAR(30),
    Manager_ID NUMERIC,
    Location_ID NUMERIC FOREIGN KEY REFERENCES Locations(Location_ID)
)

-- Table Employees
CREATE TABLE Employees (
    Employee_ID NUMERIC PRIMARY KEY,
    First_Name VARCHAR (20),
    Last_Name VARCHAR(25),
    Email VARCHAR(25),
    Phone_Number VARCHAR(20),
    Hire_Date DATE,
    Job_ID VARCHAR(10),
    Salary NUMERIC,
    Commission_PCT NUMERIC,
    Manager_ID NUMERIC FOREIGN KEY REFERENCES Employees(Employee_ID),
    Department_ID NUMERIC FOREIGN KEY REFERENCES DepartmentS(Department_ID),
)


-- Set FOREIGN KEY on Manager_ID in Departments table
ALTER TABLE Departments
ADD CONSTRAINT FK_Manager_Department_ID FOREIGN KEY (Manager_ID) REFERENCES Employees(Employee_ID);

-- Table Jobs
CREATE TABLE Jobs (
    Job_ID VARCHAR(10) PRIMARY KEY,
    Job_Title VARCHAR(35),
    Min_Salary NUMERIC,
    Max_Salary NUMERIC,
)

-- Set FOREIGN KEY on Job_ID in Empolyees table
ALTER TABLE Employees
ADD CONSTRAINT FK_Job_Employee_ID FOREIGN KEY (Job_ID) REFERENCES Jobs(Job_ID);

-- Table Jop_History
CREATE TABLE Jop_History (
    Employee_ID NUMERIC,
    Start_Date DATE,
    End_Date DATE,
    Job_ID VARCHAR(10) FOREIGN KEY REFERENCES jobs(Job_ID),
    Department_ID NUMERIC FOREIGN KEY REFERENCES Departments(Department_ID),
    PRIMARY KEY (Employee_ID, Start_Date),
    FOREIGN KEY (Employee_ID) REFERENCES Employees(Employee_ID)
)

-- Table Job_Grades
CREATE TABLE Job_Grades (
    Grade_Level VARCHAR(2) PRIMARY KEY,
    Lowest_Sal NUMERIC,
    Highest_Sal NUMERIC,
)