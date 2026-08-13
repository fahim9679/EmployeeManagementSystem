using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EmployeeManagement.Application.DTOs;

public class CreateEmployeeRequest
{
    [Required]
    [MaxLength(20)]
    public string EmployeeCode { get; set; } = string.Empty;
    
    [Required]
    [MaxLength(50)]
    public string FirstName { get; set; } = string.Empty;
    [Required]
    [MaxLength(50)]
    public string LastName { get; set; } = string.Empty;
    [Required]
    [EmailAddress]
    [MaxLength(100)]
    public string Email { get; set; } = string.Empty;

    public string Phone { get; set; } = string.Empty;

    public DateTime DateOfBirth { get; set; }

    public DateTime HireDate { get; set; }
    [Range(0, 99999.99)]
    public decimal Salary { get; set; }
    [Required]
    public int DepartmentId { get; set; }
    [Required]
    public int DesignationId { get; set; }
}
