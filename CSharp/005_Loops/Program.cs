using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();

            //While();

            //DoWhileLoop();

            //ForeachLoop();

            if (IsPrimeNumber(19))
            {
                Console.WriteLine("This is a prime number.");
            }
            else
            {
                Console.WriteLine("This is not a prime number.");
            }
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            if (number == 1 || number < 0)
            {
                result = false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private static void ForeachLoop()
        {
            string[] students = new string[3] { "Ramazan", "Ali", "Veli" };
            foreach (string student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhileLoop()
        {
            int number = 10;
            do
            {
                Console.WriteLine(number);
                number--;
            }
            while (number >= 0);
        }

        private static void While()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
        }

        private static void ForLoop()
        {
            //Example 1
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");

            //Example 2
            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");

            //Example 3
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");

            //Example 4
            for (int i = 100; i > 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!");
        }
    }
}
