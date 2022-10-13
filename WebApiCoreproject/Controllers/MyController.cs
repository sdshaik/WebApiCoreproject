using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApiCoreproject.Models;
using WebApiCoreproject.Models.Repository;

namespace WebApiCoreproject.Controllers
{
    [Route("api/employee")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly IDataRepository<Employee> _dataRepository;
        public MyController(IDataRepository<Employee> dataRepository)
        {
            _dataRepository = dataRepository;
        }
        // Get all Employees
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = _dataRepository.GetAll();
            return Ok(employees);
        }
        //get Employee by id

        [HttpGet("{id}",Name ="Get")]
        public IActionResult Get(int id)
        {
            Employee employee = _dataRepository.Get(id);
            if (employee == null)
            {
                return NotFound();
            }

            return Ok(employee);
        }
        //Add Employee
        public IActionResult Post([FromBody]Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("No Employee is found");
            }
            _dataRepository.Add(employee);
            return CreatedAtRoute(
                "Get",
                new {Id=employee.Emp_Id},
                employee);

        }
        // Update Employye
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]Employee employee)
        {
            if (employee == null)
            {
                return BadRequest("No Employeee is Found");
            }
            Employee employeeToUpdate= _dataRepository.Get(id);
            if (employeeToUpdate == null)
            {
                return NotFound("No Employee is found");
            }
            _dataRepository.Update(employeeToUpdate, employee);
             return NoContent();
        }
        //Delete Employee
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Employee employee= _dataRepository.Get(id);
         if (employee == null)
            {
                return NotFound("No Employee is found");
            }
         _dataRepository.Delete(employee);
            return NoContent();
        }
    }
}
