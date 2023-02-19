using Employee.Application;
using Employee.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeContext _employeeContext;

        public EmployeeRepository(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public async Task<Domain.Employee> Create(Domain.Employee employee)
        {
            _employeeContext.Employees.Add(employee);
            await _employeeContext.SaveChangesAsync();

            return employee;
        }

        public async Task Delete(int id)
        {
            var userToDelete = await _employeeContext.Employees.FindAsync(id);
            _employeeContext.Employees.Remove(userToDelete);
            await _employeeContext.SaveChangesAsync();


        }

        public async Task<IEnumerable<Domain.Employee>> Get()
        {
            return await _employeeContext.Employees.ToListAsync();
        }

        public async Task<Domain.Employee> Get(int id)
        {
            return await _employeeContext.Employees.FindAsync(id);
        }

        public async Task Update(Domain.Employee employee)
        {
            _employeeContext.Entry(employee).State = EntityState.Modified;
            await _employeeContext.SaveChangesAsync();

        }

        public static List<Domain.Employee> lstMembers = new List<Domain.Employee>()
        {
           new Domain.Employee{  Id =1 ,Name= "Kirtesh Shah", Type ="G" , Address="Vadodara"},
           new Domain.Employee{  Id =2 ,Name= "Mahesh Shah", Type ="S" , Address="Dabhoi"},
           new Domain.Employee{  Id =3 ,Name= "Nitya Shah", Type ="G" , Address="Mumbai"},
           new Domain.Employee{  Id =4 ,Name= "Dilip Shah", Type ="S" , Address="Dabhoi"},
           new Domain.Employee{  Id =5 ,Name= "Hansa Shah", Type ="S" , Address="Dabhoi"},
           new Domain.Employee{  Id =6 ,Name= "Mita Shah", Type ="G" , Address="Surat"}
        };

        public List<Domain.Employee> GetAllEmployees()
        {
            return lstMembers;
        }
    }
}
