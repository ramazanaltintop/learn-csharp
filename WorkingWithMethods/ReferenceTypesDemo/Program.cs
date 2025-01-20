using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Ramazan"
            };
            Customer customer2 = customer;
            Product product = new Product();

            Person person1 = customer;
            Person person2 = new Employee();

            PersonDal personDal = new PersonDal();
            personDal.Add(new Person());
            personDal.Add(new Customer());
            personDal.Add(new Employee());
            personDal.Add(new Visitor());
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
    class Customer : Person
    {
        public string CreditCardNo { get; set; }
    }
    class Employee : Person
    {
        public decimal Salary { get; set; }
    }
    class Visitor : Person
    {
        public decimal VisitorCard { get; set; }
    }
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class PersonDal
    {
        public void Add(Person person)
        {
            
        }
    }
}
