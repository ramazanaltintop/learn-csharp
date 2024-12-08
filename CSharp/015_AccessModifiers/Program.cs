using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_AccessModifiers
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Customer
    {
        private int Id { get; set; }
        protected int CustomerId { get; set; }
        public void Save()
        {
            Id += 1;
        }
        public void Delete()
        {
            Id -= -1;
        }
    }
    class Student : Customer
    {
        public void Save2()
        {
            Customer customer = new Customer();
            CustomerId = 1;
        }
    }

    public class Course
    {
        public string Name { get; set; }
        private class NestedClass
        {

        }
    }
}
