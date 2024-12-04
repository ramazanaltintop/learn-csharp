using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Conditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //If - Else
            var number1 = 12;
            if (number1 == 10)
            {
                Console.WriteLine("Number is 10.");
            }
            else
            {
                Console.WriteLine("Number is not 10.");
            }

            //Single Line If
            var number2 = 13;
            Console.WriteLine(number2 == 10 ? "Number is 10" : "Number is not 10");

            //If - Else If - Else
            var number3 = 33;
            if (number3 == 35)
            {
                Console.WriteLine("Number is 35.");
            }
            else if (number3 == 40)
            {
                Console.WriteLine("Number is 40.");
            }
            else
            {
                Console.WriteLine("Number is not 35 or 40.");
            }

            //Switch
            var number4 = 40;
            switch(number4)
            {
                case 25:
                    Console.WriteLine("Number is 25.");
                    break;
                case 35:
                    Console.WriteLine("Number is 35");
                    break;
                default:
                    Console.WriteLine("Number is not 25 or 35.");
                    break;
            }

            //Example
            var number5 = -50;
            if (number5 >= 0 && number5 <= 100)
            {
                Console.WriteLine("Number5 is between 0-100");
            }
            else if (number5 > 100 && number5 <= 200)
            {
                Console.WriteLine("Number5 is between 101-200");
            }
            else if (number5 > 200 || number5 < 0)
            {
                Console.WriteLine("Number5 is less than 0 or greater than 200");
            }

            //Nested If
            var number6 = 90;
            if (number6 < 100)
            {
                if (number6 >= 90)
                {
                    Console.WriteLine("Number6 is between 90-100");
                }
            }
        }
    }
}