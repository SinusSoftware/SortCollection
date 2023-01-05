using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class TimSort
    {
        private List<int> integers = new();
        private List<int> randomIntegers = new();
        private List<string> greekAlphabet = new();
        private List<Car> cars = new();

        [TestInitialize]
        public void TestInitialize()
        {
            integers = SupportSortingTest.GenerateSmallIntegers();
            randomIntegers = SupportSortingTest.CreateRandomArray(100, 1, 100).ToList();
            greekAlphabet = SupportSortingTest.GenerateGreekAlphabet();
            cars = SupportSortingTest.GenerateCars();
        }

        [TestMethod]
        public void TimSortTest()
        {
            //var sortedList = integers.SortWithTimSort();

            //int[] arr = { -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12 };
            int[] arr = { -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12 , -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12 };

            List<int> numbers = new();
            for(int i = 100; i > 0; i--)
            {
                numbers.Add(i);
            }

            //var sortedList = randomIntegers.SortWithTimSort(0, randomIntegers.Count());
            var sortedList = numbers.SortWithTimSort(3, 50);
            //Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
            //var testTim = arr.SortWithTimSort();

            string test = "";

           

        }
    }
}
