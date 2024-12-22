using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BusinessLayer.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", 
            "Users.xml",
            "User",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataTest()
        {
            UserManager userManager = new UserManager();

            var name = TestContext.DataRow["name"].ToString();
            var telephone = TestContext.DataRow["telephone"].ToString();
            var email = TestContext.DataRow["email"].ToString();

            var result = userManager.AddUser(name, telephone, email);
            Assert.IsTrue(result);
        }
        [DataSource("MyDataSource"), TestMethod]
        public void DataTest2()
        {
            OperationManager operationManager = new OperationManager();

            int x = Convert.ToInt32(TestContext.DataRow["x"]);
            int y = Convert.ToInt32(TestContext.DataRow["y"]);
            int expected = Convert.ToInt32(TestContext.DataRow["expected"]);

            int actual = operationManager.Add(x, y);

            Assert.AreEqual(expected, actual);
        }
    }
}