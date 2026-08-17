-- Exercise 5: Return Data from a Stored Procedure
CREATE PROCEDURE sp_GetEmployeeCountByDept
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;