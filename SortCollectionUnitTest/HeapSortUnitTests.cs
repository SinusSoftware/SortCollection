using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class HeapSortUnitTests
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
        public void HeapSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithHeapSort(new SortByYearAscending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortCarSortByYearDescendingTest()
        {
            var sortedList = cars.SortWithHeapSort(new SortByYearDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortCarSortByDefaultTest()
        {
            var sortedList = cars.SortWithHeapSort();
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortCarSortByMakeDescendingTest()
        {
            var sortedList = cars.SortWithHeapSort(new SortByMakeDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortIntegerTest()
        {
            var sortedList = integers.SortWithHeapSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortIntegerRangeDefaultComparerTest()
        {
            var sortedList = integers.SortWithHeapSort(2, 6, Comparer<int>.Default);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithHeapSort(2, 6);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortStringTest()
        {
            var sortedList = greekAlphabet.SortWithHeapSort();
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithHeapSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortIntegerRandomRangeTest()
        {
            var heapSortedList = randomIntegers.SortWithHeapSort(index, count);
            var standardSort = randomIntegers.ToList();
            standardSort.Sort(index, count, Comparer<int>.Default);
            Assert.IsTrue(standardSort.SequenceEqual(heapSortedList));
        }
    }
}
