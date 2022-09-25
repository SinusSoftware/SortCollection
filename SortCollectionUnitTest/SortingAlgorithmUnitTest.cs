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
        public void Test()
        {
            //int c[] = {510774, 227011, 100894, 44842, 19930, 8858, 3937, 1750, 701, 301, 132, 57, 23, 10, 4, 1
            //randomIntegers.Sort();
            //Assert.IsTrue(CheckRandomIntegerList(randomIntegers.ToList()));
            //ints.Sort()
            //ints.SortWithBubbleSort()

            //var merge = ints.SortWithMergeSort();
        }

        [TestMethod]
        public void ShellSortTest2()
        {
            //var sortedList2 = greekAlphabet.SortWithShellSort(SortingAlgorithm.GapSequences.Pratt);
            //var sortedList = integers.SortWithShellSort();
        }

        [TestMethod]
        public void ShellSortIntegerRangeTest2()
        {
            //var sortedList = integers.SortWithShellSort(2, 4, Comparer<int>.Default);
            //Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

    }
}