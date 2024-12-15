using Prototype.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Concrete
{
    public class Employee : IClonablePrototype<Employee>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }
    }
}
