using EmployeeManagement.Application.Interfaces;
using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _repository;

        public DepartmentService(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Department>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Department?> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
        
        public async Task<Department> AddAsync(Department department)
        {
           return await _repository.AddAsync(department);
        }

        public Task UpdateAsync(Department department)
        {
            return _repository.UpdateAsync(department);
        }
        public Task DeleteAsync(int id)
        {
            return _repository.DeleteAsync(id);
        }
    }
}
