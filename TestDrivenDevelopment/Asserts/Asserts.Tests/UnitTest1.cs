using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Asserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            const double input = 144;
            const double expected = 12;
            double actual = Math.Sqrt(input);
            Assert.AreEqual(expected, actual, "{0} sayısının karekökü {1} olmalıdır", input, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double expected = 3.1622;
            //Formula: |expected - actual| <= delta
            double delta = 0.0001;
            double actual = Math.Sqrt(10);
            Assert.AreEqual(expected, actual, delta);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string expected = "MERHABA";
            string actual = "merhaba";
            Assert.AreEqual(expected, actual, true);
        }
        [TestMethod]
        public void TestMethod4()
        {
            const double notExpected = 0;
            var actual = Math.Pow(5, 0);
            Assert.AreNotEqual(notExpected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var numbers = new byte[] { 1, 2, 3 };
            var otherNumbers = numbers;
            numbers[0] = 4;
            otherNumbers[1] = 5;
            Assert.AreSame(numbers, otherNumbers);
        }
        [TestMethod]
        public void TestMethod6()
        {
            int a = 20;
            int b = a;
            Assert.AreEqual(a, b, "AreEqual fail oldu!...");
            Assert.AreNotSame(a, b, "AreNotSame fail oldu!...");
        }
        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(1, 1);
            Assert.Inconclusive("Bu test yeterli değildir!...");
        }
        [TestMethod]
        public void TestMethod8()
        {
            var number = 25m;
            Assert.IsInstanceOfType(number, typeof(decimal));
            Assert.IsNotInstanceOfType(number, typeof(int));
        }
        [TestMethod]
        public void TestMethod9()
        {
            Assert.IsTrue(10 % 2 == 0);
            Assert.IsFalse(10 % 2 == 1);
        }
        [TestMethod]
        public void TestMethod10()
        {
            List<string> names = new List<string>() { "Ramazan", "Ahmet", "Veli" };

            var firstNameStartingWithC = names.FirstOrDefault(n => n.StartsWith("C"));
            var firstNameStartingWithR = names.FirstOrDefault(n => n.StartsWith("R"));

            Assert.IsNull(firstNameStartingWithC, "IsNull başarısız oldu!...");
            Assert.IsNotNull(firstNameStartingWithR, "IsNotNull başarısız oldu!...");
        }
        [TestMethod]
        public void TestMethod11()
        {
            try
            {
                int number = 7;
                int result = number / 0;
            }
            catch (DivideByZeroException)
            {
                Assert.Fail("Test başarısız oldu!...");
            }
        }
    }
}
