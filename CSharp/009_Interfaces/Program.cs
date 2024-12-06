using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            //Demo();(

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MysqlCustomerDal()
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void Intro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer
            {
                Id = 1,
                FirstName = "Ramazan",
                LastName = "ALTINTOP",
                Address = "A Cd."
            });

            Student student = new Student()
            {
                Id = 1,
                FirstName = "Ali",
                LastName = "Doe",
                Department = "CS"
            };
            manager.Add(student);

            Worker worker = new Worker()
            {
                Id = 1,
                FirstName = "Veli",
                LastName = "Doe",
                Department = "Production"
            };
            manager.Add(worker);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }

}
