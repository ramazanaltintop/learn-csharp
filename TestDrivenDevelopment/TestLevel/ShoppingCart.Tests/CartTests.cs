using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTests
    {
        private CartManager _cartManager;
        private CartItem _cartItem;
        [TestInitialize]
        public void TestInitialize()
        {
            _cartManager = new CartManager();
            _cartItem = new CartItem
            {
                Product = new Product
                {
                    ProductId = 1,
                    ProductName = "Laptop",
                    UnitPrice = 25500
                },
                Quantity = 1
            };
            _cartManager.Add(_cartItem);
        }
        [TestCleanup]
        public void TestCleanup()
        {
            _cartManager.Clear();
        }
        [TestMethod]
        public void Sepete_urun_eklenebilmelidir()
        {
            //Arrange
            const int expected = 1;

            //Act
            var actual = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sepette_olan_urun_cikarilabilmelidir()
        {
            //Arrange
            var expected = _cartManager.TotalItems - 1;

            //Act
            _cartManager.Remove(1);
            var actual = _cartManager.TotalItems;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Sepet_temizlenebilmelidir()
        {
            //Arrange
            var expected = 0;

            //Act
            _cartManager.Clear();
            var actual = _cartManager.TotalItems;
            var actual2 = _cartManager.TotalQuantity;

            //Assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected, actual2);
        }
    }
}
