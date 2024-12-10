using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _025_Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operations operations = new Operations(12, 13);
            //Console.WriteLine(operations.Add2());
            //Console.WriteLine(operations.Add(25, 50));

            var type = typeof(Operations);

            //Operations operations = (Operations)Activator.CreateInstance(type, 15, 25);
            //Console.WriteLine(operations.Add(3,5));
            //Console.WriteLine(operations.Add2());

            var instance = Activator.CreateInstance(type, 12, 35);
            MethodInfo methodInfo = instance.GetType().GetMethod("Add2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("-----------------");

            var methods = type.GetMethods();
            foreach ( var method in methods )
            {
                Console.WriteLine("Method name: {0}", method.Name);
                foreach (var parameter in method.GetParameters())
                {
                    Console.WriteLine("Parameter: {0}", parameter.Name);
                }
                foreach (var attribute in method.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute: {0}", attribute.GetType().Name);
                }
            }
        }
    }

    public class Operations
    {
        private int _number1;
        private int _number2;
        public Operations(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
        public int Add(int number1, int number2)
        {
            return number1 + number2;
        }
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }
        public int Add2()
        {
            return _number1 + _number2;
        }
        [MethodName("Multiplies two numbers")]
        public int Multiply2()
        {
            return _number1 * _number2;
        }
    }

    public class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string message)
        {
            
        }
    }
}
