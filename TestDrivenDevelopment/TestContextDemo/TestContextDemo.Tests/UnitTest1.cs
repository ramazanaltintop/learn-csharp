using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestContextDemo.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine("--TestInitialize--\n");
            TestContext.WriteLine("Test adı : {0}", TestContext.TestName);
            TestContext.WriteLine("Test durumu : {0}", TestContext.CurrentTestOutcome);
            TestContext.Properties["info"] = "This is extra information";
        }

        [TestCleanup]
        public void TestCleanup()
        {
            TestContext.WriteLine("--TestCleanup--\n");
            TestContext.WriteLine("Test adı : {0}", TestContext.TestName);
            TestContext.WriteLine("Test durumu : {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test bilgi : {0}", TestContext.Properties["info"]);
        }

        [TestMethod]
        public void TestMethod1()
        {
            TestContext.WriteLine("--TestMethod1--\n");
            TestContext.WriteLine("Test adı : {0}", TestContext.TestName);
            TestContext.WriteLine("Test durumu : {0}", TestContext.CurrentTestOutcome);
            TestContext.WriteLine("Test sınıfı : {0}", TestContext.FullyQualifiedTestClassName);
            TestContext.WriteLine("Test bilgi : {0}", TestContext.Properties["info"]);
            Assert.AreEqual(1, 1);
        }
    }
}
