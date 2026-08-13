using EmployeeManagement.Application.DTOs;
using EmployeeManagement.Application.Interfaces;
using EmployeeManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Application.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<List<Employee>> GetAllAsync()
        {
            return await _employeeRepository.GetAllAsync();
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            return await _employeeRepository.GetByIdAsync(id);
        }
        public Task<Employee> CreateAsync(CreateEmployeeRequest request)
        {
            var employee = new Employee
            {
                EmployeeCode = request.EmployeeCode,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phone = request.Phone,
                DateOfBirth=request.DateOfBirth,
                HireDate = request.HireDate,
                Salary = request.Salary,
                DepartmentId = request.DepartmentId,
                DesignationId = request.DesignationId
            };
            return _employeeRepository.AddAsync(employee);
        }
        public async Task UpdateAsync(Employee employee)
        {
            await _employeeRepository.UpdateAsync(employee);
        }
        public async Task DeleteAsync(int id)
        {
            await _employeeRepository.DeleteAsync(id);
        }

        

        
    }
}
