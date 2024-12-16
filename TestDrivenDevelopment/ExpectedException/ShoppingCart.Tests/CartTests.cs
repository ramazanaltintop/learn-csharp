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
        private static CartManager _cartManager;
        private static CartItem _cartItem;

        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
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

        [ClassCleanup]
        public static void ClassCleanup()
        {
            _cartManager.Clear();
        }

        [TestMethod]
        public void Sepete_farkli_urunden_1_adet_eklendiginde_sepetteki_toplam_urun_adedi_ve_eleman_sayisi_birer_artmalidır()
        {
            //Arrange
            int totalQuantity = _cartManager.TotalQuantity;
            int totalItems = _cartManager.TotalItems;

            //Act
            _cartManager.Add(new CartItem
            {
                Product = new Product
                {
                    ProductId = 2,
                    ProductName = "Mouse",
                    UnitPrice = 500
                },
                Quantity = 1
            });

            int expectedTotalQuantity = totalQuantity + 1;
            int expectedTotalItems = totalItems + 1;

            //Assert
            Assert.AreEqual(expectedTotalItems, _cartManager.TotalItems);
            Assert.AreEqual(expectedTotalQuantity, _cartManager.TotalQuantity);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
        public void Sepette_ayni_urunden_ikinci_kez_eklendiginde_hata_vermelidir()
        {
            _cartManager.Add(_cartItem);
        }
    }
}
