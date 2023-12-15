using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class RadixSortUnitTests
    {
        private List<uint> integers = new();
        private List<uint> randomIntegers = new();
        private List<CarUInt> cars = new();

        [TestInitialize]
        public void TestInitialize()
        {
            integers = SupportSortingTest.GenerateSmallUInt();
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
            var sortedList = integers.SortWithRadixSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerListUInt(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithRadixSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerListUInt(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithRadixSort(2, 6);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortCarSortByYearAscendingRangeTest()
        {
            var sortedList = cars.SortWithRadixSortBy(2, 6, car => car.Year);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscendingRangeUInt(sortedList.ToList()));

        }
    }
}
