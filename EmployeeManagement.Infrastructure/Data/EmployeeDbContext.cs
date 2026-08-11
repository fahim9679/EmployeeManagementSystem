using EmployeeManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Infrastructure.Data;

public class EmployeeDbContext:DbContext
{
    public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options):base(options)
    {
        
    }

    public DbSet<Department> Departments =>Set<Department>();
    public DbSet<Designation> Designations =>Set<Designation>();
    public DbSet<Employee> Employees =>Set<Employee>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Employee>()
            .Property(e => e.Salary)
            .HasPrecision(18, 2);
    }
}

