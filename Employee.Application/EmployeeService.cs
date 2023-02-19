using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application
{
    public class EmployeeService : IEmployeeService
    {

        private readonly IEmployeeRepository employeeRepository;
        public EmployeeService(IEmployeeRepository memberRepository)
        {
            this.employeeRepository = memberRepository;
        }
        List<Domain.Employee> IEmployeeService.GetAllEmployees()
        {
            return this.employeeRepository.GetAllEmployees();
        }


    }
}
