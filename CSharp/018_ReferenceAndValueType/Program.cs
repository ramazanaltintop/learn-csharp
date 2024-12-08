using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018_ReferenceAndValueType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 20;
            // İkinci sayının değeri eşittir birinci sayının değeridir.
            number2 = number1;
            number1 = 30;

            Console.WriteLine(number2);

            string[] cities = new string[] { "Ankara", "Adana", "Afyon" };      //101
            string[] cities2 = new string[] { "Bolu", "Balıkesir", "Bursa" };   //102
            // cities2'nin referansı eşittir cities'in referansıdır.
            cities2 = cities;
            cities[0] = "Rize";
            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }
            foreach (var city in cities2)
            {
                Console.WriteLine(city);
            }
            DataTable dataTable;
            DataTable dataTable2 = new DataTable();
            dataTable = dataTable2;
        }
    }
}
