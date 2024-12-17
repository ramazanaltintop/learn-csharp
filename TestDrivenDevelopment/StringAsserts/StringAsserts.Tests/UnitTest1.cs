using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace StringAsserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void StringContainsTest()
        {
            StringAssert.Contains("Merhaba Test Dünyası", "est");
        }
        [TestMethod]
        public void StringMatchesTest()
        {
            StringAssert.Matches("Merhaba test dünyası", new Regex(@"[a-zA-z]"));
            StringAssert.DoesNotMatch("Merhaba test dünyası", new Regex(@"[0-9]"));
        }
        [TestMethod]
        public void StartsWithTest()
        {
            StringAssert.StartsWith("Merhaba test dünyası", "Merhaba");
        }
        [TestMethod]
        public void EndsWithTest()
        {
            StringAssert.EndsWith("Merhaba test dünyası", "ünyası");
        }
    }
}
