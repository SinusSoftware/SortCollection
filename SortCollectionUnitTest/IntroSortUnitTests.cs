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
        private List<Car> cars = new();

        [TestInitialize]
        public void TestInitialize()
        {
            integers = SupportSortingTest.GenerateSmallIntegers();
            randomIntegers = SupportSortingTest.CreateRandomArray(3000, 1, 2).ToList();
            cars = SupportSortingTest.GenerateCars();
        }

        [TestMethod]
        public void IntroSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithIntroSort(0, cars.Count, car => car.Year);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }
        
        [TestMethod]
        public void IntroSortSortIntegerTest()
        {
            var sortedList = integers.SortWithIntroSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
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
