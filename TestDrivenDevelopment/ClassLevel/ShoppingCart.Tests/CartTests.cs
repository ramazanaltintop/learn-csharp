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
        public void Sepete_farkli_urunden_1_adet_eklendiginde_sepetteki_toplam_urun_adedi_ve_eleman_sayisi_birer_artmalidir()
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
                    ProductName = "Monitor",
                    UnitPrice = 10000
                },
                Quantity = 1
            });

            int expectedTotalQuantity = totalQuantity + 1;
            int expectedTotalItems = totalItems + 1;

            //Assert
            Assert.AreEqual(expectedTotalQuantity, _cartManager.TotalQuantity);
            Assert.AreEqual(expectedTotalItems, _cartManager.TotalItems);
        }

        [TestMethod]
        public void Sepette_olan_urunden_1_adet_eklendiginde_toplam_urun_adedi_bir_artmali_eleman_sayisi_ayni_kalmalidir()
        {
            //Arrange
            int totalQuantity = _cartManager.TotalQuantity;
            int totalItems = _cartManager.TotalItems;

            //Act
            _cartManager.Add(_cartItem);

            int expectedTotalQuantity = totalQuantity + 1;
            int expectedTotalItems = totalItems;

            //Assert
            Assert.AreEqual(expectedTotalQuantity, _cartManager.TotalQuantity);
            Assert.AreEqual(expectedTotalItems, _cartManager.TotalItems);

        }
    }
}
