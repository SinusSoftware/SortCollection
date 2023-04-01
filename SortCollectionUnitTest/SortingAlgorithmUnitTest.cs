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
        public void Test2()
        {

            var test4 = integers.SortWithBubbleSortDescending();
            var sortedList = integers.SortWithBubbleSortDescending(Comparer<int>.Default);
            var test7 = cars.SortWithBubbleSortByDescending(c => c.Year);

            
            string test = "";
            
        }

        [TestMethod]
        public void Test()
        {
            //greekAlphabet.so
            //IsNullOrEmpty
            //greekAlphabet.OrderBy();

            /*
            var test1 = greekAlphabet.IsNullOrEmpty();
            var test2 = greekAlphabet.Where(w => w.IsNullOrEmpty()).FirstOrDefault();
            var test3 = greekAlphabet.Where(w => w.IsNullOrEmpty());

            var test4 = integers.Where(w => w > 5).SortWithBubbleSortByDescending();
            var test5 = integers.Where(w => w > 5).OrderBy(o => o);


            List<uint> uIntegers = new()
            {
                 4,
                 7,
                 2,
                 1,
                 8,
                 9,
                 3,
                 6,
                 5
             };

            var test6 = uIntegers.Where(w => w > 5).SortWithRadixSort();
            var test7 = cars.Where(w => w.Year > 2000).SortWithCountingSort(c => c.Year);
            var test8 = cars.Where(w => w.Year > 2000).SortWithBubbleSort(c => c.Make);
            var test9 = cars.Where(w => w.Year > 2000).OrderBy(c => c.Make);

            string test = "";
            */
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