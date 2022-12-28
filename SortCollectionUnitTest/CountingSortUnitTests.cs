using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class CountingSortUnitTests
    {
        private List<int> integers = new();
        private List<uint> uintegers = new();
        private List<int> randomIntegers = new();
        private List<Car> cars = new();

        [TestInitialize]
        public void TestInitialize()
        {
            integers = SupportSortingTest.GenerateSmallIntegers();
            uintegers = SupportSortingTest.GenerateSmallUInt();
            randomIntegers = SupportSortingTest.CreateRandomArray(10000, 1, 10000).ToList();
            cars = SupportSortingTest.GenerateCars();
        }


        [TestMethod]
        public void CountingSortUIntegerTest()
        {
            var sortedList = uintegers.SortWithCountingSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerListUInt(sortedList.ToList()));
        }


        [TestMethod]
        public void CountingSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithCountingSort(car => car.Year);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void CountingSortIntegerTest()
        {
            var sortedList = integers.SortWithCountingSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void CountingSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithCountingSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }
    }
}
