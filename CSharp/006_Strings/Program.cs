using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            var sentence = "My name is Ali";

            var result = sentence.Length;
            Console.WriteLine(result);

            var result2 = sentence.Clone();
            sentence = "My name is Ramazan";
            Console.WriteLine(sentence);
            Console.WriteLine(result2);

            bool result3 = sentence.EndsWith("n");
            Console.WriteLine(result3);

            bool result4 = sentence.StartsWith("My name");
            Console.WriteLine(result4);

            var result5 = sentence.IndexOf("name");
            Console.WriteLine(result5);

            var result6 = sentence.IndexOf(" ");
            Console.WriteLine(result6);

            var result7 = sentence.LastIndexOf(" ");
            Console.WriteLine(result7);

            var result8 = sentence.Insert(0, "Hello, ");
            Console.WriteLine(result8);

            var result9 = sentence.Substring(11);
            Console.WriteLine(result9);

            var result10 = sentence.Substring(3,4);
            Console.WriteLine(result10);

            var result11 = sentence.ToLower();
            Console.WriteLine(result11);

            var result12 = sentence.ToUpper();
            Console.WriteLine(result12);

            var result13 = sentence.Replace(" ", "-");
            Console.WriteLine(result13);

            var result14 = sentence.Remove(2);
            Console.WriteLine(result14);

            var result15 = sentence.Remove(2, 5);
            Console.WriteLine(result15);
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Rize";

            //Bellekte 3.degisken tanimladigimiz icin onerilmez.
            //string result = city + city2;
            //Console.WriteLine(result);

            //Bellekte 3.degisken tanimlamadigimiz icin iyi oldu.
            //BEST PRACTICE
            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
