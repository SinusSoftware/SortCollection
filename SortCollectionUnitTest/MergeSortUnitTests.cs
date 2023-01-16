using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class MergeSortUnitTests
    {
        private List<int> integers = new();
        private List<int> randomIntegers = new();
        private List<string> greekAlphabet = new();
        private List<Car> cars = new();
        private int index = default;
        private int count = default;

        [TestInitialize]
        public void TestInitialize()
        {
            integers = SupportSortingTest.GenerateSmallIntegers();
            randomIntegers = SupportSortingTest.CreateRandomArray(10000, 1, 10000).ToList();
            greekAlphabet = SupportSortingTest.GenerateGreekAlphabet();
            cars = SupportSortingTest.GenerateCars();

            Random random = new();
            index = random.Next(1000, 4000);
            count = random.Next(1000, 5000);
        }

        [TestMethod]
        public void MergeSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithMergeSort(new SortByYearAscending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortCarSortByYearDescendingTest()
        {
            var sortedList = cars.SortWithMergeSort(new SortByYearDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortCarSortByDefaultTest()
        {
            var sortedList = cars.SortWithMergeSort();
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortCarSortByMakeDescendingTest()
        {
            var sortedList = cars.SortWithMergeSort(new SortByMakeDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortIntegerTest()
        {
            var sortedList = integers.SortWithMergeSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortIntegerRangeDefaultComparerTest()
        {
            var sortedList = integers.SortWithMergeSort(2, 6, Comparer<int>.Default);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithMergeSort(2, 6);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortStringTest()
        {
            var sortedList = greekAlphabet.SortWithMergeSort();
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithMergeSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortIntegerRandomRangeTest()
        {
            var sortedList = randomIntegers.SortWithMergeSort(index, count);
            var standardSort = randomIntegers.ToList();
            standardSort.Sort(index, count, Comparer<int>.Default);
            Assert.IsTrue(standardSort.SequenceEqual(sortedList));
        }
    }
}
