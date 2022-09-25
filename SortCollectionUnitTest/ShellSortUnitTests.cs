﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class ShellSortUnitTests
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

        #region GapSequences.Shell

        [TestMethod]
        public void ShellSortCarSortByYearAscending_Shell_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearAscending(), SortingAlgorithm.GapSequences.Shell);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByYearDescending_Shell_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearDescending(), SortingAlgorithm.GapSequences.Shell);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByDefault_Shell_Test()
        {
            var sortedList = cars.SortWithShellSort(SortingAlgorithm.GapSequences.Shell);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByMakeDescending_Shell_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByMakeDescending(), SortingAlgorithm.GapSequences.Shell);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortInteger_Shell_Test()
        {
            var sortedList = integers.SortWithShellSort(SortingAlgorithm.GapSequences.Shell);
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortIntegerRange_Shell_Test()
        {
            var sortedList = integers.SortWithShellSort(2, 6, Comparer<int>.Default, SortingAlgorithm.GapSequences.Shell);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortString_Shell_Test()
        {
            var sortedList = greekAlphabet.SortWithShellSort(SortingAlgorithm.GapSequences.Shell);
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortRandomInteger_Shell_Test()
        {
            var sortedList = randomIntegers.SortWithShellSort(SortingAlgorithm.GapSequences.Shell);
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region GapSequences.Hibbard

        [TestMethod]
        public void ShellSortCarSortByYearAscending_Hibbard_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearAscending(), SortingAlgorithm.GapSequences.Hibbard);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByYearDescending_Hibbard_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearDescending(), SortingAlgorithm.GapSequences.Hibbard);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByDefault_Hibbard_Test()
        {
            var sortedList = cars.SortWithShellSort(SortingAlgorithm.GapSequences.Hibbard);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByMakeDescending_Hibbard_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByMakeDescending(), SortingAlgorithm.GapSequences.Hibbard);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortInteger_Hibbard_Test()
        {
            var sortedList = integers.SortWithShellSort(SortingAlgorithm.GapSequences.Hibbard);
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortIntegerRange_Hibbard_Test()
        {
            var sortedList = integers.SortWithShellSort(2, 6, Comparer<int>.Default, SortingAlgorithm.GapSequences.Hibbard);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortString_Hibbard_Test()
        {
            var sortedList = greekAlphabet.SortWithShellSort(SortingAlgorithm.GapSequences.Hibbard);
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortRandomInteger_Hibbard_Test()
        {
            var sortedList = randomIntegers.SortWithShellSort(SortingAlgorithm.GapSequences.Hibbard);
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region GapSequences.PapernovStasevich

        [TestMethod]
        public void ShellSortCarSortByYearAscending_PapernovStasevich_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearAscending(), SortingAlgorithm.GapSequences.PapernovStasevich);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByYearDescending_PapernovStasevich_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearDescending(), SortingAlgorithm.GapSequences.PapernovStasevich);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByDefault_PapernovStasevich_Test()
        {
            var sortedList = cars.SortWithShellSort(SortingAlgorithm.GapSequences.PapernovStasevich);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByMakeDescending_PapernovStasevich_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByMakeDescending(), SortingAlgorithm.GapSequences.PapernovStasevich);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortInteger_PapernovStasevich_Test()
        {
            var sortedList = integers.SortWithShellSort(SortingAlgorithm.GapSequences.PapernovStasevich);
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortIntegerRange_PapernovStasevich_Test()
        {
            var sortedList = integers.SortWithShellSort(2, 6, Comparer<int>.Default, SortingAlgorithm.GapSequences.PapernovStasevich);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortString_PapernovStasevich_Test()
        {
            var sortedList = greekAlphabet.SortWithShellSort(SortingAlgorithm.GapSequences.PapernovStasevich);
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortRandomInteger_PapernovStasevich_Test()
        {
            var sortedList = randomIntegers.SortWithShellSort(SortingAlgorithm.GapSequences.PapernovStasevich);
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region GapSequences.Pratt

        [TestMethod]
        public void ShellSortCarSortByYearAscending_Pratt_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearAscending(), SortingAlgorithm.GapSequences.Pratt);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByYearDescending_Pratt_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearDescending(), SortingAlgorithm.GapSequences.Pratt);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByDefault_Pratt_Test()
        {
            var sortedList = cars.SortWithShellSort(SortingAlgorithm.GapSequences.Pratt);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByMakeDescending_Pratt_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByMakeDescending(), SortingAlgorithm.GapSequences.Pratt);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortInteger_Pratt_Test()
        {
            var sortedList = integers.SortWithShellSort(SortingAlgorithm.GapSequences.Pratt);
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortIntegerRange_Pratt_Test()
        {
            var sortedList = integers.SortWithShellSort(2, 6, Comparer<int>.Default, SortingAlgorithm.GapSequences.Pratt);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortString_Pratt_Test()
        {
            var sortedList = greekAlphabet.SortWithShellSort(SortingAlgorithm.GapSequences.Pratt);
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortRandomInteger_Pratt_Test()
        {
            var sortedList = randomIntegers.SortWithShellSort(SortingAlgorithm.GapSequences.Pratt);
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region GapSequences.Knuth

        [TestMethod]
        public void ShellSortCarSortByYearAscending_Knuth_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearAscending(), SortingAlgorithm.GapSequences.Knuth);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByYearDescending_Knuth_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearDescending(), SortingAlgorithm.GapSequences.Knuth);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByDefault_Knuth_Test()
        {
            var sortedList = cars.SortWithShellSort(SortingAlgorithm.GapSequences.Knuth);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByMakeDescending_Knuth_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByMakeDescending(), SortingAlgorithm.GapSequences.Knuth);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortInteger_Knuth_Test()
        {
            var sortedList = integers.SortWithShellSort(SortingAlgorithm.GapSequences.Knuth);
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortIntegerRange_Knuth_Test()
        {
            var sortedList = integers.SortWithShellSort(2, 6, Comparer<int>.Default, SortingAlgorithm.GapSequences.Knuth);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortString_Knuth_Test()
        {
            var sortedList = greekAlphabet.SortWithShellSort(SortingAlgorithm.GapSequences.Knuth);
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortRandomInteger_Knuth_Test()
        {
            var sortedList = randomIntegers.SortWithShellSort(SortingAlgorithm.GapSequences.Knuth);
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region GapSequences.IncerpiSedgewick

        [TestMethod]
        public void ShellSortCarSortByYearAscending_IncerpiSedgewick_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearAscending(), SortingAlgorithm.GapSequences.IncerpiSedgewick);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByYearDescending_IncerpiSedgewick_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearDescending(), SortingAlgorithm.GapSequences.IncerpiSedgewick);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByDefault_IncerpiSedgewick_Test()
        {
            var sortedList = cars.SortWithShellSort(SortingAlgorithm.GapSequences.IncerpiSedgewick);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByMakeDescending_IncerpiSedgewick_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByMakeDescending(), SortingAlgorithm.GapSequences.IncerpiSedgewick);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortInteger_IncerpiSedgewick_Test()
        {
            var sortedList = integers.SortWithShellSort(SortingAlgorithm.GapSequences.IncerpiSedgewick);
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortIntegerRange_IncerpiSedgewick_Test()
        {
            var sortedList = integers.SortWithShellSort(2, 6, Comparer<int>.Default, SortingAlgorithm.GapSequences.IncerpiSedgewick);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortString_IncerpiSedgewick_Test()
        {
            var sortedList = greekAlphabet.SortWithShellSort(SortingAlgorithm.GapSequences.IncerpiSedgewick);
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortRandomInteger_IncerpiSedgewick_Test()
        {
            var sortedList = randomIntegers.SortWithShellSort(SortingAlgorithm.GapSequences.IncerpiSedgewick);
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region GapSequences.Sedgewick1982

        [TestMethod]
        public void ShellSortCarSortByYearAscending_Sedgewick1982_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearAscending(), SortingAlgorithm.GapSequences.Sedgewick1982);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByYearDescending_Sedgewick1982_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearDescending(), SortingAlgorithm.GapSequences.Sedgewick1982);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByDefault_Sedgewick1982_Test()
        {
            var sortedList = cars.SortWithShellSort(SortingAlgorithm.GapSequences.Sedgewick1982);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByMakeDescending_Sedgewick1982_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByMakeDescending(), SortingAlgorithm.GapSequences.Sedgewick1982);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortInteger_Sedgewick1982_Test()
        {
            var sortedList = integers.SortWithShellSort(SortingAlgorithm.GapSequences.Sedgewick1982);
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortIntegerRange_Sedgewick1982_Test()
        {
            var sortedList = integers.SortWithShellSort(2, 6, Comparer<int>.Default, SortingAlgorithm.GapSequences.Sedgewick1982);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortString_Sedgewick1982_Test()
        {
            var sortedList = greekAlphabet.SortWithShellSort(SortingAlgorithm.GapSequences.Sedgewick1982);
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortRandomInteger_Sedgewick1982_Test()
        {
            var sortedList = randomIntegers.SortWithShellSort(SortingAlgorithm.GapSequences.Sedgewick1982);
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region GapSequences.Sedgewick1986

        [TestMethod]
        public void ShellSortCarSortByYearAscending_Sedgewick1986_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearAscending(), SortingAlgorithm.GapSequences.Sedgewick1986);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByYearDescending_Sedgewick1986_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearDescending(), SortingAlgorithm.GapSequences.Sedgewick1986);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByDefault_Sedgewick1986_Test()
        {
            var sortedList = cars.SortWithShellSort(SortingAlgorithm.GapSequences.Sedgewick1986);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByMakeDescending_Sedgewick1986_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByMakeDescending(), SortingAlgorithm.GapSequences.Sedgewick1986);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortInteger_Sedgewick1986_Test()
        {
            var sortedList = integers.SortWithShellSort(SortingAlgorithm.GapSequences.Sedgewick1986);
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortIntegerRange_Sedgewick1986_Test()
        {
            var sortedList = integers.SortWithShellSort(2, 6, Comparer<int>.Default, SortingAlgorithm.GapSequences.Sedgewick1986);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortString_Sedgewick1986_Test()
        {
            var sortedList = greekAlphabet.SortWithShellSort(SortingAlgorithm.GapSequences.Sedgewick1986);
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortRandomInteger_Sedgewick1986_Test()
        {
            var sortedList = randomIntegers.SortWithShellSort(SortingAlgorithm.GapSequences.Sedgewick1986);
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region GapSequences.Tokuda

        [TestMethod]
        public void ShellSortCarSortByYearAscending_Tokuda_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearAscending(), SortingAlgorithm.GapSequences.Tokuda);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByYearDescending_Tokuda_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearDescending(), SortingAlgorithm.GapSequences.Tokuda);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByDefault_Tokuda_Test()
        {
            var sortedList = cars.SortWithShellSort(SortingAlgorithm.GapSequences.Tokuda);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByMakeDescending_Tokuda_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByMakeDescending(), SortingAlgorithm.GapSequences.Tokuda);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortInteger_Tokuda_Test()
        {
            var sortedList = integers.SortWithShellSort(SortingAlgorithm.GapSequences.Tokuda);
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortIntegerRange_Tokuda_Test()
        {
            var sortedList = integers.SortWithShellSort(2, 6, Comparer<int>.Default, SortingAlgorithm.GapSequences.Tokuda);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortString_Tokuda_Test()
        {
            var sortedList = greekAlphabet.SortWithShellSort(SortingAlgorithm.GapSequences.Tokuda);
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortRandomInteger_Tokuda_Test()
        {
            var sortedList = randomIntegers.SortWithShellSort(SortingAlgorithm.GapSequences.Tokuda);
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region GapSequences.Ciura

        [TestMethod]
        public void ShellSortCarSortByYearAscending_Ciura_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearAscending(), SortingAlgorithm.GapSequences.Ciura);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByYearDescending_Ciura_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByYearDescending(), SortingAlgorithm.GapSequences.Ciura);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByDefault_Ciura_Test()
        {
            var sortedList = cars.SortWithShellSort(SortingAlgorithm.GapSequences.Ciura);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortCarSortByMakeDescending_Ciura_Test()
        {
            var sortedList = cars.SortWithShellSort(new SortByMakeDescending(), SortingAlgorithm.GapSequences.Ciura);
            Assert.IsTrue(SupportSortingTest.CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortInteger_Ciura_Test()
        {
            var sortedList = integers.SortWithShellSort(SortingAlgorithm.GapSequences.Ciura);
            Assert.IsTrue(SupportSortingTest.CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortIntegerRange_Ciura_Test()
        {
            var sortedList = integers.SortWithShellSort(2, 6, Comparer<int>.Default, SortingAlgorithm.GapSequences.Ciura);
            Assert.IsTrue(SupportSortingTest.CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortString_Ciura_Test()
        {
            var sortedList = greekAlphabet.SortWithShellSort(SortingAlgorithm.GapSequences.Ciura);
            Assert.IsTrue(SupportSortingTest.CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void ShellSortRandomInteger_Ciura_Test()
        {
            var sortedList = randomIntegers.SortWithShellSort(SortingAlgorithm.GapSequences.Ciura);
            Assert.IsTrue(SupportSortingTest.CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion
    }
}
