namespace EmployeeManagement.Domain.Entities;

public class Employee
{
    public int Id { get; set; }

    public string EmployeeCode { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    public DateTime HireDate { get; set; }

    public decimal Salary { get; set; }

    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;

    public int DesignationId { get; set; }
    public Designation Designation { get; set; } = null!;

    public bool IsActive { get; set; } = true;
}