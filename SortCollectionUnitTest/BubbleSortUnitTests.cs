using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class BubbleSortUnitTests
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

            Random random = new ();
            index = random.Next(1000, 4000);
            count = random.Next(1000, 5000);

        }

        [TestMethod]
        public void BubbleSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithBubbleSort(new SortByYearAscending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortCarSortByYearDescendingTest()
        {
            var sortedList = cars.SortWithBubbleSort(new SortByYearDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortCarSortByDefaultTest()
        {
            var sortedList = cars.SortWithBubbleSort();
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortCarSortByMakeDescendingTest()
        {
            var sortedList = cars.SortWithBubbleSort(new SortByMakeDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortIntegerTest()
        {
            var sortedList = integers.SortWithBubbleSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortIntegerRangeDefaultComparerTest()
        {
            var sortedList = integers.SortWithBubbleSort(2, 6, Comparer<int>.Default);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithBubbleSort(2, 6);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortStringTest()
        {
            var sortedList = greekAlphabet.SortWithBubbleSort();
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithBubbleSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortIntegerRandomRangeTest()
        {
            var sortedList = randomIntegers.SortWithBubbleSort(index, count);
            var standardSort = randomIntegers.ToList();
            standardSort.Sort(index, count, Comparer<int>.Default);
            Assert.IsTrue(standardSort.SequenceEqual(sortedList));
        }
    }
}
