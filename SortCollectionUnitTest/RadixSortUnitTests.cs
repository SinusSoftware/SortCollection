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
        private List<uint> randomUIntegers = new();
        private List<CarUInt> cars = new();

        [TestInitialize]
        public void TestInitialize()
        {
            uintegers = SupportSortingTest.GenerateSmallUIntegers();
            randomUIntegers = SupportSortingTest.CreateRandomArrayUIntegers(10000, 1, 10000).ToList();
            cars = SupportSortingTest.GenerateCarsUIntegers();
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
            Assert.IsTrue(SupportSortingTest.CheckIntegerListUIntegers(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRangeFuncTest()
        {
            var sortedList = uintegers.SortWithRadixSort(2, 6, i => i);
            Assert.IsTrue(SupportSortingTest.CheckUIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRangeTest()
        {
            var sortedList = uintegers.SortWithRadixSort(2, 6);
            Assert.IsTrue(SupportSortingTest.CheckUIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortRandomUIntegerTest()
        {
            var sortedList = randomUIntegers.SortWithRadixSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomUIntegerList(sortedList.ToList()));
        }
    }
}
