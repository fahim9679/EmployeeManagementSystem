using EmployeeManagement.Application.DTOs;
using EmployeeManagement.Application.Services;
using EmployeeManagement.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeesController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }
    [HttpGet]
    public async Task<ActionResult<List<Employee>>> GetAll()
    {
        var employees = await _employeeService.GetAllAsync();
        return Ok(employees);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult<Employee>> GetById(int id)
    {
        var employee = await _employeeService.GetByIdAsync(id);

        if (employee is null)
            return NotFound();

        return Ok(employee);
    }
    [HttpPost]
    public async Task<ActionResult<Employee>> Create(CreateEmployeeRequest request)
    {
        var employee = await _employeeService.CreateAsync(request);

        return CreatedAtAction(
            nameof(GetById),
            new { id = employee.Id },
            employee);
    }
}
