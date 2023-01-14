using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class RadixSortUnitTests
    {
        private List<uint> uintegers = new();
        private List<uint> randomIntegers = new();
        private List<CarUInt> cars = new();

        [TestInitialize]
        public void TestInitialize()
        {
            uintegers = SupportSortingTest.GenerateSmallUInt();
            randomIntegers = SupportSortingTest.CreateRandomArrayUInt(10000, 1, 10000).ToList();
            cars = SupportSortingTest.GenerateCarsUInt();
        }

        [TestMethod]
        public void RadixSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithRadixSort(car => car.Year);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscendingUInt(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerTest()
        {
            var sortedList = uintegers.SortWithRadixSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerListUInt(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithRadixSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerListUInt(sortedList.ToList()));
        }
    }
}
