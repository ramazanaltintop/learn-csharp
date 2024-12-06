using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();

            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Ramazan";
            customer.LastName = "ALTINTOP";
            customer.City = "Ankara";

            Customer customer2 = new Customer()
            {
                Id = 2, FirstName = "Cem", LastName = "Doe", City = "Rize"
            };
            Console.WriteLine(customer2.FirstName);
        }
    }
}
