using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class SlowSortUnitTests
    {
        private List<int> integers = new();
        private List<string> greekAlphabet = new();
        private List<Car> cars = new();
        private int index = default;
        private int count = default;

        [TestInitialize]
        public void TestInitialize()
        {
            integers = SupportSortingTest.GenerateSmallIntegers();
            greekAlphabet = SupportSortingTest.GenerateGreekAlphabet();
            cars = SupportSortingTest.GenerateCars();

            Random random = new();
            index = random.Next(1, 4);
            count = random.Next(2, 5);
        }

        [TestMethod]
        public void SlowSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithSlowSort(new SortByYearAscending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void SlowSortCarSortByYearDescendingTest()
        {
            var sortedList = cars.SortWithSlowSort(new SortByYearDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void SlowSortCarSortByDefaultTest()
        {
            var sortedList = cars.SortWithSlowSort();
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void SlowSortCarSortByMakeDescendingTest()
        {
            var sortedList = cars.SortWithSlowSort(new SortByMakeDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void SlowSortIntegerTest()
        {
            var sortedList = integers.SortWithSlowSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void SlowSortIntegerRangeDefaultComparerTest()
        {
            var sortedList = integers.SortWithSlowSort(2, 6, Comparer<int>.Default);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void SlowSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithSlowSort(2, 6);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void SlowSortStringTest()
        {
            var sortedList = greekAlphabet.SortWithSlowSort();
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void SlowSortIntegerRandomRange_Shell_Test()
        {
            var sortedList = integers.SortWithSlowSort(index, count);
            var standardSort = integers.ToList();
            standardSort.Sort(index, count, Comparer<int>.Default);
            Assert.IsTrue(standardSort.SequenceEqual(sortedList));
        }


    }
}
