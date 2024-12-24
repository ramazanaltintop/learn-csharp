using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Demo.Tests
{
    [TestClass]
    public class GrouperTests
    {
        private List<Measurement> CreateMeasurementList(int count)
        {
            var measurements = new List<Measurement>();
            for (int i = 0; i < count; i++)
            {
                measurements.Add(new Measurement
                {
                    highestValue = 10,
                    lowestValue = 1
                });
            }
            return measurements;
        }
        [TestMethod]
        public void bir_elemanli_liste_birerli_gruplanmak_istendiginde_grup_sayisi_bir_olmalidir()
        {
            var measurements = CreateMeasurementList(1);
            var grouper = new Grouper(1);
            var groups = grouper.Group(measurements);

            var expectedCount = 1;
            var actualCount = groups.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void alti_elemanli_liste_ikiserli_gruplanmak_istendiginde_grup_sayisi_uc_olmalidir()
        {
            var measurements = CreateMeasurementList(6);
            var grouper = new Grouper(2);
            var groups = grouper.Group(measurements);

            var expectedCount = 3;
            var actualCount = groups.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [TestMethod]
        public void elli_elemanli_liste_onarli_gruplanmak_istendiginde_grup_sayisi_bes_olmalidir()
        {
            var measurements = CreateMeasurementList(50);
            var grouper = new Grouper(10);
            var groups = grouper.Group(measurements);

            var expectedCount = 5;
            var actualCount = groups.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }
    }
}
