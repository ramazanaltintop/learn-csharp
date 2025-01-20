using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeDal : IEmployeeDal
    {
        public List<Employee> GetAll()
        {
            return new List<Employee> {
                new Employee {
                    Id = 1, FirstName = "Ramazan", LastName = "ALTINTOP",
                    BirthYear = 2000, IdentityNumber = "123456", Salary = 32500
                },new Employee {
                    Id = 2, FirstName = "ABC", LastName = "HKLD",
                    BirthYear = 2001, IdentityNumber = "214819", Salary = 33000
                }
            };
        }
    }
}
