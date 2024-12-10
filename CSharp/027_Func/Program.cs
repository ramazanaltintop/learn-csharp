using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _027_Func
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Example1
            Func<int, int, int> add = Add;
            Console.WriteLine(add(25, 25));

            //Example2
            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 100);
            };
            Console.WriteLine(getRandomNumber());

            //Example3
            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());
        }
        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
