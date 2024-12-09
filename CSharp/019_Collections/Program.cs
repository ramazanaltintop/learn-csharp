using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();

            //ArrayList();

            //List();

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("book", "kitap");
            dictionary.Add("table", "tablo");
            dictionary.Add("computer", "bilgisayar");

            //Console.WriteLine(dictionary["table"]);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine(dictionary.ContainsKey("glass"));
            Console.WriteLine(dictionary.ContainsKey("table"));

            Console.WriteLine(dictionary.ContainsValue("gözlük"));
            Console.WriteLine(dictionary.ContainsValue("bilgisayar"));

            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine(dictionary[key]);
            }
        }

        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("Kırıkkale");

            // True Döner
            Console.WriteLine(cities.Contains("Ankara"));

            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer() { Id = 1, FirstName = "Ramazan" });
            //customers.Add(new Customer() { Id = 2, FirstName = "Cemre"});

            List<Customer> customers = new List<Customer>()
            {
                new Customer() { Id = 1, FirstName = "Ramazan" },
                new Customer() { Id = 2, FirstName = "Cemre" }
            };

            var customer2 = new Customer()
            {
                Id = 3,
                FirstName = "Veli"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer(){Id = 4, FirstName = "Aslı"},
                new Customer(){Id = 5, FirstName = "Nilay"}
            });

            // False Döner
            Console.WriteLine(customers.Contains(new Customer() { Id = 1, FirstName = "Ramazan" }));

            // True Döner
            Console.WriteLine(customers.Contains(customer2));

            //customers.Clear();

            var index = customers.IndexOf(customer2);
            Console.WriteLine("Index: {0}", index);

            customers.Add(customer2);

            var index2 = customers.LastIndexOf(customer2);
            Console.WriteLine("Index: {0}", index2);

            customers.Insert(0, customer2);

            customers.Remove(customer2);

            customers.RemoveAll(c => c.FirstName == "Veli");

            foreach (var customer in customers)
            {
                Console.WriteLine("Id: {0}, FirstName: {1}", customer.Id, customer.FirstName);
            }

            var count = customers.Count;
            Console.WriteLine(count);
        }

        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Adana");
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            cities.Add("Kırıkkale");
            Console.WriteLine(cities[2]);
            cities.Add(1);
            cities.Add('R');
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
        }

        private static void Intro()
        {
            string[] cities = new string[2] { "Ankara", "Kırıkkale" };
            cities = new string[3];
            Console.WriteLine(cities[0]);
        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
    }
}
