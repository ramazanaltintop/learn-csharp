using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestAttributes1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [Owner("Ramazan")]
        [TestCategory("Tester")]
        [Priority(1)]
        [TestProperty("Guncelleyen","Cem")]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Ramazan")]
        [TestCategory("Tester")]
        [Priority(1)]
        [TestProperty("Guncelleyen","Cem")]
        [TestProperty("Guncelleyen2","Ali")]
        public void TestMethod2()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Ramazan")]
        [TestCategory("Tester")]
        [TestCategory("Developer")]
        [TestCategory("Demo")]
        [Priority(1)]
        public void TestMethod3()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Ahmet")]
        [TestCategory("Developer")]
        [Priority(2)]
        public void TestMethod4()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Owner("Ahmet")]
        [TestCategory("Developer")]
        [Priority(2)]
        public void TestMethod5()
        {
            Assert.AreEqual(1, 1);
        }
    }
}