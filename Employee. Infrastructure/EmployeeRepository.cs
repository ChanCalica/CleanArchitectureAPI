using Employee.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public static List<Domain.Employee> lstEmployees = new List<Domain.Employee>()
        {
           new Domain.Employee{  Id =1 ,Name= "Kirtesh Shah", Type ="G" , Address="Vadodara"},
           new Domain.Employee{  Id =2 ,Name= "Mahesh Shah", Type ="S" , Address="Dabhoi"},
           new Domain.Employee{  Id =3 ,Name= "Nitya Shah", Type ="G" , Address="Mumbai"},
           new Domain.Employee{  Id =4 ,Name= "Dilip Shah", Type ="S" , Address="Dabhoi"},
           new Domain.Employee{  Id =5 ,Name= "Hansa Shah", Type ="S" , Address="Dabhoi"},
           new Domain.Employee{  Id =6 ,Name= "Mita Shah", Type ="G" , Address="Surat"}
        };
        public List<Domain.Employee> GetEmployees()
        {
            return lstEmployees;
        }
    }
}
