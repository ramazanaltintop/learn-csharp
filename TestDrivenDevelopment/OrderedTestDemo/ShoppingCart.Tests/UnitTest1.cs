using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShoppingCart.Tests
{
    [TestClass]
    public class CartTests
    {
        private static CartManager _cartManager;
        private static int id = 0;

        public TestContext TestContext { get; set; }

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            _cartManager = new CartManager();
        }

        [TestMethod]
        public void Sepete_urun_eklendiginde_sepetteki_urun_sayisi_1_artmalidir()
        {
            var quantity = _cartManager.TotalQuantity;

            id++;
            _cartManager.Add(new CartItem
            {
                Product = new Product
                {
                    ProductId = id,
                    ProductName = "Monitor",
                    UnitPrice = 15000
                },
                Quantity = 1
            });

            var expected = quantity + 1;
            var actual = _cartManager.TotalQuantity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sepetten_urun_cikarildiginda_sepetteki_urun_sayisi_1_azalmalidir()
        {
            var quantity = _cartManager.TotalQuantity;

            _cartManager.Remove(id);
            id--;

            var expected = quantity - 1;
            var actual = _cartManager.TotalQuantity;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Sepet_temizlendiginde_sepette_urun_kalmamalidir()
        {
            _cartManager.Clear();

            var expectedTotalQuantity = 0;
            var actualTotalQuantity = _cartManager.TotalQuantity;

            var expectedTotalItems = 0;
            var actualTotalItems = _cartManager.TotalItems;

            Assert.AreEqual(expectedTotalQuantity, actualTotalQuantity);
            Assert.AreEqual(expectedTotalItems, actualTotalItems);
        }
    }
}
