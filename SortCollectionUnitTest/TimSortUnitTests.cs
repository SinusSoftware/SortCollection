using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class TimSortUnitTests
    {
        private List<int> integers = new();
        private List<int> randomIntegers = new();
        private List<string> greekAlphabet = new();
        private List<Car> cars = new();

        [TestInitialize]
        public void TestInitialize()
        {
            integers = SupportSortingTest.GenerateSmallIntegers();
            randomIntegers = SupportSortingTest.CreateRandomArray(10000, 1, 10000).ToList();
            greekAlphabet = SupportSortingTest.GenerateGreekAlphabet();
            cars = SupportSortingTest.GenerateCars();
        }

        [TestMethod]
        public void TimSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithTimSort(new SortByYearAscending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void TimSortCarSortByYearDescendingTest()
        {
            var sortedList = cars.SortWithTimSort(new SortByYearDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void TimSortCarSortByDefaultTest()
        {
            var sortedList = cars.SortWithTimSort();
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void TimSortCarSortByMakeDescendingTest()
        {
            var sortedList = cars.SortWithTimSort(new SortByMakeDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void TimSortCarSortByMakeDescending2Test()
        {
            var sortedList = cars.SortWithTimSortDescending();
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void TimSortIntegerTest()
        {
            var sortedList = integers.SortWithTimSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }
        
        [TestMethod]
        public void TimSortSortIntegerDescendingTest()
        {
            var sortedList = integers.SortWithTimSortDescending();
            Assert.IsTrue(SupportSortingTest.CheckIntegerDescendingList(sortedList.ToList()));
        }

        [TestMethod]
        public void TimSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithTimSort(2, 6, Comparer<int>.Default);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void TimSortStringTest()
        {
            var sortedList = greekAlphabet.SortWithTimSort();
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void TimSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithTimSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }
    }
}
