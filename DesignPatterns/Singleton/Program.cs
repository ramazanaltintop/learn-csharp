using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerManager = CustomerManager.CreateAsSingleton();
            customerManager.Save();
        }
    }
    class CustomerManager
    {
        //Referansı tutmak için static bir değişken olmalıdır.
        private static CustomerManager _customerManager;

        private static object _lockObject = new object();

        //Nesne oluşumunu tek yerden sağlamak için Private olmalıdır.
        //İstemcinin, new anahtar kelimesini kullanması engellenir.
        private CustomerManager()
        {

        }

        //Tutulan referansa erişmek için bir metot tanımlanır.
        public static CustomerManager CreateAsSingleton()
        {
            //Double-checked locking
            if (_customerManager == null)
            {
                lock (_lockObject)
                {
                    if (_customerManager == null)
                    {
                        _customerManager = new CustomerManager();
                    }
                }
            }
            return _customerManager;
        }

        public void Save()
        {
            Console.WriteLine("Saved!...");
        }
    }
}