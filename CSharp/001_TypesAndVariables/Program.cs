using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_TypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Value Types

            //Byte - Value Type
            byte number1 = 0; // 0
            byte number2 = 255; // 2^8-1
            Console.WriteLine("ByteMin: {0}, ByteMax: {1}", number1, number2);

            //Short - Value Type
            short number3 = -32768; // -2^15
            short number4 = 32767; // 2^15 -1
            Console.WriteLine("ShortMin: {0}, ShortMax: {1}", number3, number4);

            //Integer - Value Type
            int number5 = -2147483648; // -2^31
            int number6 = 2147483647; // +2^31-1
            Console.WriteLine("IntMin: {0}, IntMax: {1}", number5, number6);

            //Long - Value Type
            long number7 = -9223372036854775808; // -2^63
            long number8 = 9223372036854775807; // 2^63+1
            Console.WriteLine("LongMin: {0}, LongMax: {1}", number7, number8);

            //Double - Value Type
            double number9 = 13.012345678901234; // 64 bit
            Console.WriteLine("Double: {0}", number9);

            //Decimal - Value Type
            decimal number10 = 13.0123456789012345678901234567m;
            Console.WriteLine("Decimal: {0}", number10);

            //Enum - Value Type
            Console.WriteLine((int)Days.Friday);

            //Bool (Boolean) - Value Type
            bool condition1 = true;
            bool condition2 = false;
            Console.WriteLine("Boolean1: {0}, Boolean2: {1}", condition1, condition2);

            //Char - Value Type
            char character = 'R';
            Console.WriteLine("Character is {0}", (int)character);

            //Var Keyword
            var number11 = 12;
            number11 = 'A';
            Console.WriteLine(number11);
        }
    }
    enum Days
    {
        Monday = 1, Tuesday = 4, Wednesday, Thursday, Friday, Saturday, Sunday
    }
}
