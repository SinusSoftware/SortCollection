using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class ParallelMergeSortUnitTests
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
        public void ParallelMergeSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithParallelMergeSort(new SortByYearAscending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelMergeSortCarSortByYearDescendingTest()
        {
            var sortedList = cars.SortWithParallelMergeSort(new SortByYearDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelMergeSortCarSortByDefaultTest()
        {
            var sortedList = cars.SortWithParallelMergeSort();
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelMergeSortCarSortByMakeDescendingTest()
        {
            var sortedList = cars.SortWithParallelMergeSort(new SortByMakeDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelMergeSortIntegerTest()
        {
            var sortedList = integers.SortWithParallelMergeSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelMergeSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithParallelMergeSort(2, 6, Comparer<int>.Default);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelMergeSortStringTest()
        {
            var sortedList = greekAlphabet.SortWithParallelMergeSort();
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void ParallelMergeSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithParallelMergeSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }
    }
}
