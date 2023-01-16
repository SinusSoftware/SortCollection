using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class RadixSortUnitTests
    {
        private List<uint> uintegers = new();
        private List<uint> randomUIntegers = new();
        private List<CarUInt> cars = new();
        private int index = default;
        private int count = default;

        [TestInitialize]
        public void TestInitialize()
        {
            uintegers = SupportSortingTest.GenerateSmallUIntegers();
            randomUIntegers = SupportSortingTest.CreateRandomArrayUIntegers(10000, 1, 10000).ToList();
            cars = SupportSortingTest.GenerateCarsUIntegers();

            Random random = new();
            index = random.Next(1000, 4000);
            count = random.Next(1000, 5000);
        }

        #region GroupBitLength default

        [TestMethod]
        public void RadixSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithRadixSort(car => car.Year);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscendingUInt(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerTest()
        {
            var sortedList = uintegers.SortWithRadixSort();
            Assert.IsTrue(SupportSortingTest.CheckIntegerListUIntegers(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRangeFuncTest()
        {
            var sortedList = uintegers.SortWithRadixSort(2, 6, i => i);
            Assert.IsTrue(SupportSortingTest.CheckUIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRangeTest()
        {
            var sortedList = uintegers.SortWithRadixSort(2, 6);
            Assert.IsTrue(SupportSortingTest.CheckUIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortRandomUIntegerTest()
        {
            var sortedList = randomUIntegers.SortWithRadixSort();
            Assert.IsTrue(SupportSortingTest.CheckRandomUIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRandomRangeTest()
        {
            var sortedList = randomUIntegers.SortWithRadixSort(index, count);
            var standardSort = randomUIntegers.ToList();
            standardSort.Sort(index, count, Comparer<uint>.Default);
            Assert.IsTrue(standardSort.SequenceEqual(sortedList));
        }

        #endregion

        #region GroupBitLength.TwoBits

        [TestMethod]
        public void RadixSortCarSortByYearAscending_TwoBits_Test()
        {
            var sortedList = cars.SortWithRadixSort(car => car.Year, SortingAlgorithm.GroupBitLength.TwoBits);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscendingUInt(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortInteger_TwoBits_Test()
        {
            var sortedList = uintegers.SortWithRadixSort(SortingAlgorithm.GroupBitLength.TwoBits);
            Assert.IsTrue(SupportSortingTest.CheckIntegerListUIntegers(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRangeFunc_TwoBits_Test()
        {
            var sortedList = uintegers.SortWithRadixSort(2, 6, i => i, SortingAlgorithm.GroupBitLength.TwoBits);
            Assert.IsTrue(SupportSortingTest.CheckUIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRange_TwoBits_Test()
        {
            var sortedList = uintegers.SortWithRadixSort(2, 6, SortingAlgorithm.GroupBitLength.TwoBits);
            Assert.IsTrue(SupportSortingTest.CheckUIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortRandomUInteger_TwoBits_Test()
        {
            var sortedList = randomUIntegers.SortWithRadixSort(SortingAlgorithm.GroupBitLength.TwoBits);
            Assert.IsTrue(SupportSortingTest.CheckRandomUIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRandomRange_TwoBits_Test()
        {
            var sortedList = randomUIntegers.SortWithRadixSort(index, count, SortingAlgorithm.GroupBitLength.TwoBits);
            var standardSort = randomUIntegers.ToList();
            standardSort.Sort(index, count, Comparer<uint>.Default);
            Assert.IsTrue(standardSort.SequenceEqual(sortedList));
        }

        #endregion

        #region GroupBitLength.FourBits

        [TestMethod]
        public void RadixSortCarSortByYearAscending_FourBits_Test()
        {
            var sortedList = cars.SortWithRadixSort(car => car.Year, SortingAlgorithm.GroupBitLength.FourBits);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscendingUInt(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortInteger_FourBits_Test()
        {
            var sortedList = uintegers.SortWithRadixSort(SortingAlgorithm.GroupBitLength.FourBits);
            Assert.IsTrue(SupportSortingTest.CheckIntegerListUIntegers(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRangeFunc_FourBits_Test()
        {
            var sortedList = uintegers.SortWithRadixSort(2, 6, i => i, SortingAlgorithm.GroupBitLength.FourBits);
            Assert.IsTrue(SupportSortingTest.CheckUIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRange_FourBits_Test()
        {
            var sortedList = uintegers.SortWithRadixSort(2, 6, SortingAlgorithm.GroupBitLength.FourBits);
            Assert.IsTrue(SupportSortingTest.CheckUIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortRandomUInteger_FourBits_Test()
        {
            var sortedList = randomUIntegers.SortWithRadixSort(SortingAlgorithm.GroupBitLength.FourBits);
            Assert.IsTrue(SupportSortingTest.CheckRandomUIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRandomRange_FourBits_Test()
        {
            var sortedList = randomUIntegers.SortWithRadixSort(index, count, SortingAlgorithm.GroupBitLength.FourBits);
            var standardSort = randomUIntegers.ToList();
            standardSort.Sort(index, count, Comparer<uint>.Default);
            Assert.IsTrue(standardSort.SequenceEqual(sortedList));
        }

        #endregion

        #region GroupBitLength.FourBits

        [TestMethod]
        public void RadixSortCarSortByYearAscending_EightBits_Test()
        {
            var sortedList = cars.SortWithRadixSort(car => car.Year, SortingAlgorithm.GroupBitLength.EightBits);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscendingUInt(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortInteger_EightBits_Test()
        {
            var sortedList = uintegers.SortWithRadixSort(SortingAlgorithm.GroupBitLength.EightBits);
            Assert.IsTrue(SupportSortingTest.CheckIntegerListUIntegers(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRangeFunc_EightBits_Test()
        {
            var sortedList = uintegers.SortWithRadixSort(2, 6, i => i, SortingAlgorithm.GroupBitLength.EightBits);
            Assert.IsTrue(SupportSortingTest.CheckUIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRange_EightBits_Test()
        {
            var sortedList = uintegers.SortWithRadixSort(2, 6, SortingAlgorithm.GroupBitLength.EightBits);
            Assert.IsTrue(SupportSortingTest.CheckUIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortRandomUInteger_EightBits_Test()
        {
            var sortedList = randomUIntegers.SortWithRadixSort(SortingAlgorithm.GroupBitLength.EightBits);
            Assert.IsTrue(SupportSortingTest.CheckRandomUIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRandomRange_EightBits_Test()
        {
            var sortedList = randomUIntegers.SortWithRadixSort(index, count, SortingAlgorithm.GroupBitLength.EightBits);
            var standardSort = randomUIntegers.ToList();
            standardSort.Sort(index, count, Comparer<uint>.Default);
            Assert.IsTrue(standardSort.SequenceEqual(sortedList));
        }

        #endregion

        #region GroupBitLength.FourBits

        [TestMethod]
        public void RadixSortCarSortByYearAscending_SixteenBits_Test()
        {
            var sortedList = cars.SortWithRadixSort(car => car.Year, SortingAlgorithm.GroupBitLength.SixteenBits);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscendingUInt(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortInteger_SixteenBits_Test()
        {
            var sortedList = uintegers.SortWithRadixSort(SortingAlgorithm.GroupBitLength.SixteenBits);
            Assert.IsTrue(SupportSortingTest.CheckIntegerListUIntegers(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRangeFunc_SixteenBits_Test()
        {
            var sortedList = uintegers.SortWithRadixSort(2, 6, i => i, SortingAlgorithm.GroupBitLength.SixteenBits);
            Assert.IsTrue(SupportSortingTest.CheckUIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRange_SixteenBits_Test()
        {
            var sortedList = uintegers.SortWithRadixSort(2, 6, SortingAlgorithm.GroupBitLength.SixteenBits);
            Assert.IsTrue(SupportSortingTest.CheckUIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortRandomUInteger_SixteenBits_Test()
        {
            var sortedList = randomUIntegers.SortWithRadixSort(SortingAlgorithm.GroupBitLength.SixteenBits);
            Assert.IsTrue(SupportSortingTest.CheckRandomUIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void RadixSortIntegerRandomRange_SixteenBits_Test()
        {
            var sortedList = randomUIntegers.SortWithRadixSort(index, count, SortingAlgorithm.GroupBitLength.SixteenBits);
            var standardSort = randomUIntegers.ToList();
            standardSort.Sort(index, count, Comparer<uint>.Default);
            Assert.IsTrue(standardSort.SequenceEqual(sortedList));
        }

        #endregion
    }
}
