using Microsoft.VisualStudio.TestTools.UnitTesting;
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
        private List<CarUInt> carsUInt = new();

        [TestInitialize]
        public void TestInitialize()
        {
            integers = SupportSortingTest.GenerateSmallIntegers();
            uintegers = SupportSortingTest.GenerateSmallUIntegers();
            randomIntegers = SupportSortingTest.CreateRandomArray(10000, 1, 10000).ToList();
            greekAlphabet = SupportSortingTest.GenerateGreekAlphabet();
            cars = SupportSortingTest.GenerateCars();
            carsUInt = SupportSortingTest.GenerateCarsUIntegers();
        }

        [TestMethod]
        public void Test()
        {
          
        }

    }
}