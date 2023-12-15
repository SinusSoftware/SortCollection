using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace SortCollectionUnitTest
{

    [TestClass]
    public class SortingAlgorithmUnitTest
    {
        private List<int> integers = new();
        private List<int> randomIntegers = new();
        private List<uint> randomUIntegers = new();
        private List<string> greekAlphabet = new();
        private List<Car> cars = new();

        [TestInitialize]
        public void TestInitialize()
        {
            integers = SupportSortingTest.GenerateSmallIntegers();
            randomIntegers = SupportSortingTest.CreateRandomArray(1000000, 1, 1000000).ToList();
            randomUIntegers = SupportSortingTest.CreateRandomArrayUInt(1000000, 1, 1000000).ToList();
            greekAlphabet = SupportSortingTest.GenerateGreekAlphabet();
            cars = SupportSortingTest.GenerateCars();

        }


        [TestMethod]
        public void Test2()
        {

            //var test1 = integers.SortWithBubbleSortDescending();
            //var sortedList1 = integers.SortWithBubbleSortDescending(Comparer<int>.Default);
            //var testBy1 = cars.SortWithBubbleSortByDescending(c => c.Year);

            //var test2 = integers.SortWithSelectionSortDescending();
            //var sortedList2 = integers.SortWithSelectionSortDescending(Comparer<int>.Default);
            //var testBy2 = cars.SortWithSelectionSortByDescending(c => c.Year);

            //var test3 = integers.SortWithInsertionSortDescending();
            //var sortedList3 = integers.SortWithInsertionSortDescending(Comparer<int>.Default);
            //var testBy3 = cars.SortWithInsertionSortByDescending(c => c.Year);


            string test = "";


        }

        [TestMethod]
        public void RunTime_Test()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            var test = randomUIntegers.SortWithQuickSort();
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            stopWatch.Restart();
            // randomIntegers.Sort();
            var test2 = randomUIntegers.SortWithRadixSort();
            stopWatch.Stop();
            TimeSpan ts2 = stopWatch.Elapsed;
            string end = "";
        }

            [TestMethod]
        public void Test()
        {
           // var test1 = integers.SortWithQuickSort();

            var sortedList = integers.SortWithQuickSort(2, 6, Comparer<int>.Default);
            
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));

            string test = "";
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


        [TestMethod]
        public void MergeSortCarSortByDefaultTest()
        {
            var sortedList = integers.SortWithShakerSort(2, 6, Comparer<int>.Default);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));

            //var sortedList = integers.SortWithBubbleSort();
            //Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }
    }
}