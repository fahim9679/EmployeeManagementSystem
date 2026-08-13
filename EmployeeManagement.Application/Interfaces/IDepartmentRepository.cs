using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetAllAsync();
        Task<Department?> GetByIdAsync(int id);
        Task<Department> AddAsync(Department department);
        Task UpdateAsync(Department department);
        Task DeleteAsync(int id);
    }
}
