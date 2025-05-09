CREATE DATABASE ManageEmployee;
GO

USE ManageEmployee;
GO


CREATE TABLE Employee (
    Id INT PRIMARY KEY IDENTITY(1,1),
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    Salary DECIMAL(18,2) NOT NULL,
    AdminId INT NOT NULL
);

CREATE INDEX IX_Employee_AdminId ON Employee(AdminId);
