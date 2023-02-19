using Employee.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeService employeeService;
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeesController(IEmployeeService employeeService, IEmployeeRepository employeeRepository)
        {
            this.employeeService = employeeService;
            this._employeeRepository = employeeRepository;
        }
        // GET: api/<MembersController>
        [HttpGet("details")]
        public ActionResult<IList<Domain.Employee>> Get()
        {
            return Ok(this.employeeService.GetAllEmployees());
        }


        [HttpGet]
        public async Task<IEnumerable<Domain.Employee>> GetUsers()
        {
            return await _employeeRepository.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Domain.Employee>> GetUsers(int id)
        {
            return await _employeeRepository.Get(id);

        }

        [HttpPost]
        public async Task<ActionResult<Domain.Employee>> PostUsers([FromBody] Domain.Employee employee)
        {
            var newUser = await _employeeRepository.Create(employee);
            return CreatedAtAction(nameof(GetUsers), new { id = newUser.Id }, newUser);

        }

        [HttpPut]
        public async Task<ActionResult> PutUsers(int id, [FromBody] Domain.Employee employee)
        {
            if (id != employee.Id)
            {

                return BadRequest();
            }

            await _employeeRepository.Update(employee);

            return NoContent();

        }

        [HttpDelete("{id}")]

        public async Task<ActionResult> Delete(int id)
        {
            var userToDelete = await _employeeRepository.Get(id);
            if (userToDelete == null)
                return NotFound();

            await _employeeRepository.Delete(userToDelete.Id);

            return NoContent();

        }

    }
}
