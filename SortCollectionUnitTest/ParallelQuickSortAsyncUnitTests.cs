using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class ParallelQuickSortAsyncUnitTests
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
        public async Task ParallelQuickSortAsyncCarSortByYearAscendingTest()
        {
            var sortedList = await cars.SortWithParallelQuickSortAsync(new SortByYearAscending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelQuickSortCarSortByYearDescendingTest()
        {
            var sortedList = await cars.SortWithParallelQuickSortAsync(new SortByYearDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelQuickSortAsyncCarSortByDefaultTest()
        {
            var sortedList = await cars.SortWithParallelQuickSortAsync();
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelQuickSortAsyncCarSortByMakeDescendingTest()
        {
            var sortedList = await cars.SortWithParallelQuickSortAsync(new SortByMakeDescending());
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelQuickSortAsyncIntegerTest()
        {
            var sortedList = await integers.SortWithParallelQuickSortAsync();
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelQuickSortAsyncIntegerRangeTest()
        {
            var sortedList = await integers.SortWithParallelQuickSortAsync(2, 6, Comparer<int>.Default);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelQuickSortAsyncStringTest()
        {
            var sortedList = await greekAlphabet.SortWithParallelQuickSortAsync();
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelQuickSortAsyncRandomIntegerTest()
        {
            var sortedList = await randomIntegers.SortWithParallelQuickSortAsync();
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public async Task ParallelQuickSortAsyncCancelationTokenTest()
        {
            try
            {
                var cts = new CancellationTokenSource();
                cts.CancelAfter(1);
                var sortedList = await cancelationTokenIntegers.SortWithParallelQuickSortAsync(cts.Token);
                Assert.Fail("No CancellationToken");
            }
            catch (OperationCanceledException ex)
            {
                Assert.IsTrue(true);
            }
        }
    }
}
