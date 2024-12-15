using Prototype.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                FirstName = "Ramazan",
                LastName = "Doe"
            };

            var employee2 = employee.Clone();
            employee2.FirstName = "Ahmet";

            Console.WriteLine(employee.FirstName);
            Console.WriteLine(employee2.FirstName);
        }
    }
    
}
