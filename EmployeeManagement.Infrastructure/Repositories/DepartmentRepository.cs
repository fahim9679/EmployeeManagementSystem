using EmployeeManagement.Application.Interfaces;
using EmployeeManagement.Domain.Entities;
using EmployeeManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Infrastructure.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly EmployeeDbContext _context;
        public DepartmentRepository(EmployeeDbContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> GetAllAsync()
        {
            return await _context.Departments.ToListAsync();
        }

        public async Task<Department?> GetByIdAsync(int id)
        {
            return await _context.Departments.FirstOrDefaultAsync(d => d.Id == id);
        }
        public async Task<Department> AddAsync(Department department)
        {
            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();
            return department;
        }          

        public async Task UpdateAsync(Department department)
        {
            _context.Departments.Update(department);
            await _context.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var department = await GetByIdAsync(id);
            if (department == null)
            {
                return;
            }
            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();
        }
    }
}
