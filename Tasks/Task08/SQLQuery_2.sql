-- 1) Create a new database named "CompanyDB."
CREATE DATABASE CompanyDB

USE CompanyDB

-- 2) Create a schema named "Sales" within the "CompanyDB" database.
CREATE SCHEMA Sales;

-- 3) Create a table named "employees" with columns: employee_id (INT), first_name (VARCHAR), last_name (VARCHAR), and salary (DECIMAL) within the "Sales" schema.
CREATE TABLE Sales.employees (
    employee_id INT PRIMARY KEY DEFAULT(NEXT VALUE FOR ID_SQE),
    first_name VARCHAR(20),
    last_name VARCHAR(20),
    salary DECIMAL
);

CREATE SEQUENCE ID_SQE
AS INT
START WITH 1
INCREMENT BY 1

-- 4) Alter the "employees" table to add a new column named "hire_date" with the data type DATE.
ALTER TABLE Sales.employees 
ADD hire_date DATE 

-- 5) Required: Add mock data to this table use https://www.mockaroo.com
/* employees.sql (File) */

-- 6) Select all columns from the "employees" table.
SELECT *
FROM Sales.employees

-- 7) Retrieve only the "first_name" and "last_name" columns from the "employees" table.
SELECT first_name, last_name
FROM Sales.employees

-- 8) Retrieve “full name” as a one column from "first_name" and "last_name" columns from the "employees" table.
SELECT first_name + ' ' + last_name AS 'full name'
FROM Sales.employees

-- 9) Show the average salary of all employees.
SELECT AVG(salary) AS average_Salary
FROM Sales.employees

-- 10) Select employees whose salary is greater than 5000.
SELECT salary
FROM Sales.employees
WHERE salary > 5000

-- 11) Retrieve employees hired in the year 2020.
SELECT hire_date
FROM Sales.employees
WHERE YEAR(hire_date) = 2020

-- 12) List employees whose last names start with 'S.'
SELECT *
FROM Sales.employees
WHERE last_name LIKE 'S%'

-- 13) Display the top 10 highest-paid employees.
SELECT Top(10) *
FROM Sales.employees
ORDER BY salary DESC

-- 14) Find employees with salaries between 4000 and 6000.
SELECT *
FROM Sales.employees
WHERE salary BETWEEN 4000 AND 6000

-- 15) Show employees with names containing the substring 'man.'
SELECT *
FROM Sales.employees
WHERE first_name LIKE '%man' OR last_name LIKE '%man'
-- Another Answer
SELECT *
FROM Sales.employees
WHERE first_name LIKE '%man%' OR last_name LIKE '%man%'

-- 16) Display employees with a NULL value in the "hire_date" column.
SELECT *
FROM Sales.employees
WHERE hire_date IS NULL

-- 17) Select employees with a salary in the set (4000, 4500, 5000).
SELECT *
FROM Sales.employees
WHERE salary IN(4000, 4500, 5000)

-- 18) Retrieve employees hired between '2020-01-01' and '2021-01-01.'
SELECT *
FROM Sales.employees
WHERE hire_date BETWEEN '2020-01-01' AND '2021-01-01'

-- 19) List employees with salaries in descending order.
SELECT *
FROM Sales.employees
ORDER BY salary DESC

-- 20) Show the first 5 employees ordered by "last_name" in ascending order.
SELECT *
FROM Sales.employees
ORDER BY first_name

-- 21) Display employees with a salary greater than 5500 and hired in 2020.
SELECT *
FROM Sales.employees
WHERE salary > 5500 AND YEAR(hire_date) = 2020

-- 22) Select employees whose first name is 'John' or 'Jane.'
SELECT *
FROM Sales.employees
WHERE first_name IN ('John', 'Jane')

-- 23) List employees with a salary less than or equal to 5500 and a hire date after '2022-01-01.'
SELECT *
FROM Sales.employees
WHERE salary >= 5500 AND hire_date > '2022-01-01'

-- 24) Retrieve employees with a salary greater than the average salary.
SELECT *
FROM Sales.employees
WHERE salary > (SELECT AVG(salary) FROM Sales.employees)

-- 25) Display the 3rd to 7th highest-paid employees.
SELECT *
FROM Sales.employees
ORDER BY salary DESC
OFFSET 2 ROWS FETCH NEXT 5 ROWS ONLY

-- 26) List employees hired after '2021-01-01' in alphabetical order.
SELECT *
FROM Sales.employees
WHERE hire_date > '2021-01-01'
ORDER BY first_name

-- 27) Retrieve employees with a salary greater than 5000 and last name not starting with 'A.'
SELECT *
FROM Sales.employees
WHERE salary >  5000 AND last_name NOT LIKE 'A%'

-- 28) Display employees with a salary that is not NULL.
SELECT *
FROM Sales.employees
WHERE salary IS NOT NULL

-- 29) Show employees with names containing 'e' or 'i' and a salary greater than 4500.
SELECT *
FROM Sales.employees
WHERE salary >  5000 AND (first_name LIKE ('%e%') OR first_name LIKE '%i%' OR last_name LIKE ('%e%') OR last_name LIKE '%i%')
