using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortCollectionUnitTest
{

    [TestClass]
    public class SortingAlgorithmUnitTest
    {
        private List<int> integers = new();
        private List<uint> uintegers = new();
        private List<int> randomIntegers = new();
        private List<string> greekAlphabet = new();
        private List<Car> cars = new();

        [TestInitialize]
        public void TestInitialize()
        {
            integers = SupportSortingTest.GenerateSmallIntegers();
            uintegers = SupportSortingTest.GenerateSmallUInt();
            randomIntegers = SupportSortingTest.CreateRandomArray(10000, 1, 10000).ToList();
            greekAlphabet = SupportSortingTest.GenerateGreekAlphabet();
            cars = SupportSortingTest.GenerateCars();

        }

        [TestMethod]
        public void TestRadixSort()
        {
            //var sortedList1 = integers.SortWithRadixSortTest();
            //var sortedList5 = cars.SortWithRadixSortTest(cars => cars.Year);



            var sortedList3 = uintegers.SortWithRadixSort(2, 4, i => i, SortingAlgorithm.GroupBitLength.SixteenBits);
            //var sortedList6 = integers.SortWithRadixSortTest(2, 4);



            string test = "";
        }



        [TestMethod]
        public void TestNewSignatur()
        {
            var sortedList1 = integers.SortWithBubbleSort();
            var sortedList2 = integers.SortWithBubbleSort(Comparer<int>.Default);
            var sortedList3 = integers.SortWithBubbleSort(2, 4);
            var sortedList4 = integers.SortWithBubbleSort(2, 4, Comparer<int>.Default);

            var sortedList5 = cars.SortWithBubbleSort();
            cars.Sort();
            string test = "";
        }

        [TestMethod]
        public void TimSortTest()
        {
            //var sortedList = integers.SortWithTimSort();

            //int[] arr = { -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12 };
            int[] arr = { -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12, -2, 7, 15, -14, 0, 15, 0, 7, -7, -4, -13, 5, 8, -14, 12 };

            List<int> numbers = new();
            for (int i = 100; i > 0; i--)
            {
                numbers.Add(i);
            }

            //var sortedList = randomIntegers.SortWithTimSort(0, randomIntegers.Count());
            var sortedList = numbers.SortWithTimSort(11, 73, Comparer<int>.Default);
            numbers.Sort(11, 73, Comparer<int>.Default);

            bool isEqual = numbers.SequenceEqual(sortedList);
            //Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
            //var testTim = arr.SortWithTimSort();

            string test = "";



        }

    }
}