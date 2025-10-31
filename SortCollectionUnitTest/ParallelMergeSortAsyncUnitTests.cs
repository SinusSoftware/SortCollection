using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class ParallelMergeSortAsyncUnitTests
    {
        private List<int> integers = new();
        private List<int> randomIntegers = new();
        private List<int> cancelationTokenIntegers = new();
        private List<string> greekAlphabet = new();
        private List<Car> cars = new();

        [TestInitialize]
        public void TestInitialize()
        {
            integers = SupportSortingTest.GenerateSmallIntegers();
            randomIntegers = SupportSortingTest.CreateRandomArray(10000, 1, 10000).ToList();
            cancelationTokenIntegers = SupportSortingTest.CreateRandomArray(100000, 1, 100000).ToList();
            greekAlphabet = SupportSortingTest.GenerateGreekAlphabet();
            cars = SupportSortingTest.GenerateCars();
        }

        [TestMethod]
        public async Task ParallelMergeSortAsyncCarSortByYearAscendingTest()
        {
            var sortedList = await cars.SortWithParallelMergeSortAsync(new SortByYearAscending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelMergeSortCarSortByYearDescendingTest()
        {
            var sortedList = await cars.SortWithParallelMergeSortAsync(new SortByYearDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelMergeSortAsyncCarSortByDefaultTest()
        {
            var sortedList = await cars.SortWithParallelMergeSortAsync();
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelMergeSortAsyncCarSortByMakeDescendingTest()
        {
            var sortedList = await cars.SortWithParallelMergeSortAsync(new SortByMakeDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelMergeSortAsyncIntegerTest()
        {
            var sortedList = await integers.SortWithParallelMergeSortAsync();
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelMergeSortAsyncIntegerRangeTest()
        {
            var sortedList = await integers.SortWithParallelMergeSortAsync(2, 6, Comparer<int>.Default);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelMergeSortAsyncStringTest()
        {
            var sortedList = await greekAlphabet.SortWithParallelMergeSortAsync();
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelMergeSortAsyncRandomIntegerTest()
        {
            var sortedList = await randomIntegers.SortWithParallelMergeSortAsync();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelMergeSortAsyncCancelationTokenTest()
        {
            try
            {
                var cts = new CancellationTokenSource();
                cts.CancelAfter(1);
                var sortedList = await cancelationTokenIntegers.SortWithParallelMergeSortAsync(cts.Token);
                Assert.Fail("No CancellationToken");
            }
            catch (OperationCanceledException ex)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
