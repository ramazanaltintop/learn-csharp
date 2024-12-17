using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionAsserts.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private List<string> _users;

        [TestInitialize]
        public void CreateData()
        {
            _users = new List<string>();

            _users.Add("Ramazan");
            _users.Add("Ahmet");
            _users.Add("Mehmet");
        }
        [TestMethod]
        public void Elemanlar_ve_sirasi_ayni_olmalidir()
        {
            List<string> _newUsers = new List<string>();
            _newUsers.Add("Ramazan");
            _newUsers.Add("Ahmet");
            _newUsers.Add("Mehmet");
            CollectionAssert.AreEqual(_newUsers, _users);
        }
        [TestMethod]
        public void Elemanlar_ayni_fakat_sirasi_farkli_olabilir()
        {
            List<string> _newUsers = new List<string>
            {
                "Ramazan", "Mehmet", "Ahmet"
            };
            CollectionAssert.AreEquivalent(_newUsers, _users);
        }
        [TestMethod]
        public void Elemanlar_ve_sirasi_ayni_olmamalidir()
        {
            List<string> _newUsers = new List<string>();
            _newUsers.Add("Ramazan");
            _newUsers.Add("Mehmet");
            _newUsers.Add("Ahmet");
            CollectionAssert.AreNotEqual(_newUsers, _users);
        }
        [TestMethod]
        public void Elemanlar_farkli_olmalidir()
        {
            List<string> _newUsers = new List<string>
            {
                "Ramazan", "Ali", "Veli"
            };
            CollectionAssert.AreNotEquivalent(_newUsers, _users);
        }
        [TestMethod]
        public void Kullanicilar_null_deger_almamalidir()
        {
            //_users.Add(null);
            CollectionAssert.AllItemsAreNotNull(_users);
        }
        [TestMethod]
        public void Kullanicilar_benzersiz_olmalidir()
        {
            //_users.Add("Ramazan");
            CollectionAssert.AllItemsAreUnique(_users);
        }
        [TestMethod]
        public void Tum_elemanlar_ayni_tipte_olmalidir()
        {
            ArrayList list = new ArrayList
            {
                "Ramazan", "Ali", "Veli"
            };
            CollectionAssert.AllItemsAreInstancesOfType(list, typeof(string));
        }
        [TestMethod]
        public void IsSubsetOf_test()
        {
            List<string> newUsers = new List<string> { "Ahmet", "Mehmet" };
            List<string> oldUsers = new List<string> { "Ramazan", "Can" };

            CollectionAssert.IsSubsetOf(newUsers, _users);
            CollectionAssert.IsNotSubsetOf(oldUsers, _users);
        }
        [TestMethod]
        public void Contains_test()
        {
            CollectionAssert.Contains(_users, "Ramazan");
            CollectionAssert.DoesNotContain(_users, "Cem");
        }
    }
}
