using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Add();
            Add();

            var result = Add2(5, 8);
            Console.WriteLine(result);

            var result2 = Add2(25);
            Console.WriteLine(result2);

            //Ref Keyword
            int number1 = 50;
            int number2 = 75;
            var result3 = Add3(ref number1, number2);
            Console.WriteLine(result3);
            Console.WriteLine(number1);

            //Out Keyword
            int number3;
            int number4 = 75;
            var result4 = Add4(out number3, number4);
            Console.WriteLine(result4);
            Console.WriteLine(number3);

            //Method Overloading
            Console.WriteLine(Multiply(4,12));
            Console.WriteLine(Multiply(3,12,4));

            //Params Keyword
            Console.WriteLine(Add5(3,4,5,6,7));
            Console.WriteLine(Add5(1,2,3));
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2 = 40)
        {
            var result = number1 + number2;
            return result;
        }

        //Ref Keyword
        static int Add3(ref int number1, int number2)
        {
            number1 = 60;
            return number1 + number2;
        }

        //Out Keyword
        static int Add4(out int number3, int number4)
        {
            number3 = 60;
            return number3 + number4;
        }

        //Method Overloading
        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        //Params Keyword
        static int Add5(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
