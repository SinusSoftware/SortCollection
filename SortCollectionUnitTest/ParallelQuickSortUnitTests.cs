using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class ParallelQuickSortUnitTests
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
        public void ParallelQuickSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithParallelQuickSort(new SortByYearAscending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelQuickSortCarSortByYearDescendingTest()
        {
            var sortedList = cars.SortWithParallelQuickSort(new SortByYearDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelQuickSortCarSortByDefaultTest()
        {
            var sortedList = cars.SortWithParallelQuickSort();
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelQuickSortCarSortByMakeDescendingTest()
        {
            var sortedList = cars.SortWithParallelQuickSort(new SortByMakeDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelQuickSortIntegerTest()
        {
            var sortedList = integers.SortWithParallelQuickSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelQuickSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithParallelQuickSort(2, 6, Comparer<int>.Default);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelQuickSortStringTest()
        {
            var sortedList = greekAlphabet.SortWithParallelQuickSort();
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelQuickSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithParallelQuickSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }
    }
}
