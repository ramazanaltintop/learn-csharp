using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee ramazan = new Employee { FirstName = "Ramazan" };

            Employee veli = new Employee { FirstName = "Veli" };

            ramazan.AddSubordinate(veli);

            Employee ali = new Employee { FirstName = "Ali" };

            ramazan.AddSubordinate(ali);

            Employee ahmet = new Employee { FirstName = "Ahmet" };

            veli.AddSubordinate(ahmet);

            Contractor mehmet = new Contractor { FirstName = "Mehmet" };

            ali.AddSubordinate(mehmet);

            Contractor naz = new Contractor { FirstName = "Naz" };

            ali.AddSubordinate(naz);

            Console.WriteLine(ramazan.FirstName);
            foreach (Employee manager in ramazan)
            {
                Console.WriteLine("   {0}", manager.FirstName);
                foreach (IPerson employee in manager)
                {
                    Console.WriteLine("      {0}", employee.FirstName);
                }
            }
        }
    }
    interface IPerson
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Contractor : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Employee : IPerson, IEnumerable<IPerson>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        List<IPerson> _subordinates = new List<IPerson>();

        public void AddSubordinate(IPerson person)
        {
            _subordinates.Add(person);
        }

        public void RemoveSubordinate(IPerson person)
        {
            _subordinates.Remove(person);
        }

        public IPerson GetSubordinate(int index)
        {
            return _subordinates[index];
        }

        public IEnumerator<IPerson> GetEnumerator()
        {
            foreach (var subordinate in _subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}