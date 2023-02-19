using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application
{
    public interface IEmployeeService
    {

        List<Domain.Employee> GetAllEmployees();

    }
}
