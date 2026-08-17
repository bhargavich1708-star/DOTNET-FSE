using Microsoft.AspNetCore.Mvc;
using ASP_NET_Core_WebAPI.Models;
using ASP_NET_Core_WebAPI.Filters;
using System.Collections.Generic;
using System.Linq;

namespace ASP_NET_Core_WebAPI.Controllers
{
    [Route("api/Emp")]
    [ApiController]
    [CustomAuthFilter] // Custom filter applied[cite: 11]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> _employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John Doe", Salary = 50000, Permanent = true }
        };

        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<List<Employee>> GetStandardEmployeeList()
        {
            return Ok(_employees);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(int id, [FromBody] Employee inputData)
        {
            if (id <= 0) return BadRequest("Invalid employee id");
            
            var existingEmp = _employees.FirstOrDefault(e => e.Id == id);
            if (existingEmp == null) return BadRequest("Invalid employee id");

            existingEmp.Name = inputData.Name;
            existingEmp.Salary = inputData.Salary;
            existingEmp.Permanent = inputData.Permanent;

            return Ok(existingEmp);
        }
    }
}