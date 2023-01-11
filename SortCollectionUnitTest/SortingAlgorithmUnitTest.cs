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
            //greekAlphabet.so
            //IsNullOrEmpty
            //greekAlphabet.OrderBy();
            
            var test1 = greekAlphabet.IsNullOrEmpty();
            var test2 = greekAlphabet.Where(w => w.IsNullOrEmpty()).FirstOrDefault();
            var test3 = greekAlphabet.Where(w => w.IsNullOrEmpty());
        }

    }
}