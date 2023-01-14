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
        private List<int> randomIntegers = new();
        private List<Car> cars = new();

        [TestInitialize]
        public void TestInitialize()
        {
            integers = SupportSortingTest.GenerateSmallIntegers();
            randomIntegers = SupportSortingTest.CreateRandomArray(10000, 1, 10000).ToList();
            cars = SupportSortingTest.GenerateCars();
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
        public void CountingSortIntegerRangeDefaultComparerTest()
        {
            var sortedList = integers.SortWithCountingSort(2, 6, i => i);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void CountingSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithCountingSort(2, 6);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void CountingSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithCountingSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }
    }
}
