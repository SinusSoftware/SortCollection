using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class IntroSortUnitTests
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
        public void IntroSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithIntroSort(0, cars.Count, new SortByYearAscending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void IntroSortCarSortByYearDescendingTest()
        {
            var sortedList = cars.SortWithIntroSort(new SortByYearDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void IntroSortCarSortByDefaultTest()
        {
            var sortedList = cars.SortWithIntroSort();
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void IntroSortCarSortByMakeDescendingTest()
        {
            var sortedList = cars.SortWithIntroSort(new SortByMakeDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void IntroSortCarSortByMakeDescending2Test()
        {
            var sortedList = cars.SortWithIntroSortDescending();
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void IntroSortSortIntegerTest()
        {
            var sortedList = integers.SortWithIntroSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void IntroSortSortIntegerDescendingTest()
        {
            var sortedList = integers.SortWithIntroSortDescending();
            Assert.IsTrue(SupportSortingTest.CheckIntegerDescendingList(sortedList.ToList()));
        }

        [TestMethod]
        public void IntroSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithIntroSort(2, 6, Comparer<int>.Default);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void IntroSortStringTest()
        {
            var sortedList = greekAlphabet.SortWithIntroSort();
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void IntroSortTestRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithIntroSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void IntroSortQuickSortPathTest()
        {
            var quickSortPath = new List<int>();
            for (int i = 6000; i > 0; i--)
            {
                quickSortPath.Add(i);
            }
            quickSortPath.Add(17);

            var sortedList = quickSortPath.SortWithIntroSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void IntroSortTestMinusAndPlusIntegerTest()
        {
            int[] values = new int[] { -1, 17, -7852, 6843, -534, 0, 42683, -1, 18, -6528, 346778, -3254, 345, 9732 };

            var sortedList = values.SortWithIntroSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }
    }
}
