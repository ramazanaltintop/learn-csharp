using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamingConventions
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class ProductManager
    {
        // fields
        public int LargestNumber;

        private int smallestNumber;

        // properties

        public int SmallestNumber { get; set; }

        // constructor
        public ProductManager()
        {
            
        }

        // method
        public void GetAllByCategoryId(int categoryId)
        {
            // local variable
            int anyNumber;
        }
    }
}
