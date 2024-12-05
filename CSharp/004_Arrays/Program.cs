using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Option 1
            string[] students = new string[3];
            students[0] = "Ramazan";
            students[1] = "Ali";
            students[2] = "Veli";

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            //Option 2
            string[] students2 = new string[] { "Ramazan", "Ali", "Veli" };

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            //Option 3
            string[] students3 = { "Ramazan", "Ali", "Veli" };

            foreach (var student in students3)
            {
                Console.WriteLine(student);
            }

            //Option 4
            string[] students4 = new string[3] { "Ramazan", "Ali", "Veli" };

            foreach (var student in students4)
            {
                Console.WriteLine(student);
            }

            //Multidimensional Array
            //Option 1
            string[,] regions = new string[7, 3]; // 7 row 3 column
            regions[0, 0] = "Ankara";

            //Option 2
            string[,] regions2 = new string[7, 3]
            {
                { "Tekirdağ", "Kırklareli", "Edirne" },
                { "Rize", "Trabzon", "Giresun" },
                { "Ankara", "Kırıkkale", "Kırşehir" },
                { "Mersin", "Adana", "Antalya" },
                { "Ağrı", "Ardahan", "Bitlis" },
                { "Gaziantep", "Şanlıurfa", "Diyarbakır" },
                { "İzmir", "Çanakkale", "Bursa" }
            };

            for (int i = 0; i <= regions2.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions2.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions2[i, j]);
                }
                Console.WriteLine("---");
            }
        }
    }
}