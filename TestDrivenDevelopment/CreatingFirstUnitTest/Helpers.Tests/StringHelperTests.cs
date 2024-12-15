using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Girilen_ifadenin_basindaki_ve_sonundaki_fazla_bosluklar_silinmelidir()
        {
            //Arrange
            var input = "  Ramazan Altıntop  ";
            var expected = "Ramazan Altıntop";

            //Act
            var trimmedString = StringHelper.DeleteExtraSpaces(input);

            //Assert
            Assert.AreEqual(trimmedString, expected);
        }
        [TestMethod]
        public void Girilen_ifadenin_icindeki_fazla_bosluklar_silinmelidir()
        {
            //Arrange
            var input = "Ramazan     Altıntop         Veli   Ahmet           Elon      Musk";
            var expected = "Ramazan Altıntop Veli Ahmet Elon Musk";

            //Act
            var trimmedString = StringHelper.DeleteExtraSpaces(input);

            //Assert
            Assert.AreEqual(trimmedString, expected);
        }
    }
}
