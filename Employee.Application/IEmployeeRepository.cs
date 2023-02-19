using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Application
{
    public interface IEmployeeRepository
    {
        List<Domain.Employee> GetAllEmployees();

        Task<IEnumerable<Domain.Employee>> Get();
        Task<Domain.Employee> Get(int id);

        Task<Domain.Employee> Create(Domain.Employee employee);

        Task Update(Domain.Employee employee);

        Task Delete(int id);

    }
}
