using EmployeeManagement.Application.DTOs;
using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Services;

public interface IEmployeeService
{
    Task<List<Employee>> GetAllAsync();

    Task<Employee?> GetByIdAsync(int id);

    Task<Employee> CreateAsync(CreateEmployeeRequest request);

    Task UpdateAsync(Employee employee);

    Task DeleteAsync(int id);
}
