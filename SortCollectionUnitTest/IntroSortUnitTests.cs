using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SortCollectionUnitTest
{
    [TestClass]
    public class IntroSortUnitTests
    {
        private List<int> integers = new();
        private List<int> randomIntegers = new();
        private List<string> greekAlphabet = new();
        private List<Car> cars = new();

        [TestInitialize]
        public void TestInitialize()
        {
            integers = SupportSortingTest.GenerateSmallIntegers();
            randomIntegers = SupportSortingTest.CreateRandomArray(3000, 1, 2).ToList();
            greekAlphabet = SupportSortingTest.GenerateGreekAlphabet();
            cars = SupportSortingTest.GenerateCars();
        }

        [TestMethod]
        public void IntroSortTest()
        {
            var eigene = new List<int>(); 
            for (int i = 6000; i > 0; i--)
            {
                eigene.Add(i);
            }
            eigene.Add(17);


                var great2 = 2 * Math.Log(3000);
            int[] data = new int[] { -1, 25, -58964, 8547, -119, 0, 78596, -1, 25, -58964, 8547, -119, 0, 78596, -1, 25, -58964, 8547, -119, 0, 78596, -1, 25, -58964, 8547, -119, 0, 78596 };
            int[] data2 = randomIntegers.ToArray();
            //var test = eigene.IntroSort();
            //var test = eigene.IntroSort(0, eigene.Count);
           // var test = eigene.IntroSort(0, 20);

            var sortedList = cars.IntroSort(0, cars.Count, car => car.Year);


            for ( int i = 0; i < 10000; i++ )
            {
                var great = 2 * Math.Log(i);
                if(great > 16)
                {
                    string ende = "";
                }
            }
           



            //var sortedList = cars.SortWithBubbleSort(new SortByYearAscending());
            //Assert.IsTrue(SupportSortingTest.CheckCarsSortByYearAscending(sortedList.ToList()));

            string test2 = "";
        }


        private static int Partition(ref int[] data, int left, int right)
        {
            int pivot = data[right];
            int temp;
            int i = left;

            for (int j = left; j < right; ++j)
            {
                if (data[j] <= pivot)
                {
                    temp = data[j];
                    data[j] = data[i];
                    data[i] = temp;
                    i++;
                }
            }

            data[right] = data[i];
            data[i] = pivot;

            return i;
        }
    }
}
