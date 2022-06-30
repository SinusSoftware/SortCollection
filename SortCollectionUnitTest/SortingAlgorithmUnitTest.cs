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
            integers = new()
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

            greekAlphabet = new()
            {
                 "Alpha",
                 "Beta",
                 "Gamma",
                 "Delta",
                 "Epsilon",
                 "Zeta",
                 "Eta",
                 "Theta",
                 "Iota"
             };

            randomIntegers = CreateRandomArray(10000, 1, 10000).ToList();

            cars = new List<Car>()
            {
                 new Car("Ford",1992),
                 new Car("Fiat",1988),
                 new Car("Buick",1932),
                 new Car("VW", 2020),
                 new Car("Renault",2015),
                 new Car("Toyota",2006),
                 new Car("Nissan",2018),
                 new Car("Dodge",1999),
                 new Car("Honda",1977)
             };
        }

        public static int[] CreateRandomArray(int size, int lower, int upper)
        {
            var array = new int[size];
            var rand = new Random();
            for (int i = 0; i < size; i++)
                array[i] = rand.Next(lower, upper);
            return array;
        }

        private static bool CheckIntegerList(IList<int> values)
        {
            if (values[0] != 1 ||
              values[1] != 2 ||
              values[2] != 3 ||
              values[3] != 4 ||
              values[4] != 5 ||
              values[5] != 6 ||
              values[6] != 7 ||
              values[7] != 8 ||
              values[8] != 9)
            {
                return false;
            }
            return true;
        }

        private static bool CheckIntegerRangeList(IList<int> values)
        {
            if (values[0] != 4 ||
             values[1] != 7 ||
             values[2] != 1 ||
             values[3] != 2 ||
             values[4] != 3 ||
             values[5] != 6 ||
             values[6] != 8 ||
             values[7] != 9 ||
             values[8] != 5)
            {
                return false;
            }
            return true;
        }

        private static bool CheckRandomIntegerList(IList<int> values)
        {
            for (int i = 0; i < values.Count - 1; i++)
            {
                if (values[i] > values[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckAlphabet(IList<string> values)
        {
            if (values[0] != "Alpha" ||
                values[1] != "Beta" ||
                values[2] != "Delta" ||
                values[3] != "Epsilon" ||
                values[4] != "Eta" ||
                values[5] != "Gamma" ||
                values[6] != "Iota" ||
                values[7] != "Theta" ||
                values[8] != "Zeta")
            {
                return false;
            }
            return true;
        }

        private static bool CheckCarsSortByYearAscending(IList<Car> cars)
        {
            if (cars[0].Year != 1932 ||
             cars[1].Year != 1977 ||
             cars[2].Year != 1988 ||
             cars[3].Year != 1992 ||
             cars[4].Year != 1999 ||
             cars[5].Year != 2006 ||
             cars[6].Year != 2015 ||
             cars[7].Year != 2018 ||
             cars[8].Year != 2020)
            {
                return false;
            }
            return true;
        }

        private static bool CheckCarsSortByYearDescending(IList<Car> cars)
        {
            if (cars[0].Year != 2020 ||
             cars[1].Year != 2018 ||
             cars[2].Year != 2015 ||
             cars[3].Year != 2006 ||
             cars[4].Year != 1999 ||
             cars[5].Year != 1992 ||
             cars[6].Year != 1988 ||
             cars[7].Year != 1977 ||
             cars[8].Year != 1932)
            {
                return false;
            }
            return true;
        }

        private static bool CheckCarsSortByMakeAscending(IList<Car> cars)
        {
            if (cars[0].Make != "Buick" ||
             cars[1].Make != "Dodge" ||
             cars[2].Make != "Fiat" ||
             cars[3].Make != "Ford" ||
             cars[4].Make != "Honda" ||
             cars[5].Make != "Nissan" ||
             cars[6].Make != "Renault" ||
             cars[7].Make != "Toyota" ||
             cars[8].Make != "VW")
            {
                return false;
            }
            return true;
        }

        private static bool CheckCarsSortByMakeDescending(IList<Car> cars)
        {
            if (cars[0].Make != "VW" ||
             cars[1].Make != "Toyota" ||
             cars[2].Make != "Renault" ||
             cars[3].Make != "Nissan" ||
             cars[4].Make != "Honda" ||
             cars[5].Make != "Ford" ||
             cars[6].Make != "Fiat" ||
             cars[7].Make != "Dodge" ||
             cars[8].Make != "Buick")
            {
                return false;
            }
            return true;
        }

        #region BubbleSort Tests

        [TestMethod]
        public void BubbleSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithBubbleSort(new SortByYearAscending());
            Assert.IsTrue(CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortCarSortByYearDescendingTest()
        {
            var sortedList = cars.SortWithBubbleSort(new SortByYearDescending());
            Assert.IsTrue(CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortCarSortByDefaultTest()
        {
            var sortedList = cars.SortWithBubbleSort();
            Assert.IsTrue(CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortCarSortByMakeDescendingTest()
        {
            var sortedList = cars.SortWithBubbleSort(new SortByMakeDescending());
            Assert.IsTrue(CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortIntegerTest()
        {
            var sortedList = integers.SortWithBubbleSort();
            Assert.IsTrue(CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithBubbleSort(2, 6, Comparer<int>.Default);
            Assert.IsTrue(CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortStringTest()
        {
            var sortedList = greekAlphabet.SortWithBubbleSort();
            Assert.IsTrue(CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void BubbleSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithBubbleSort();
            Assert.IsTrue(CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region SelectionSort Tests

        [TestMethod]
        public void SelectionSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithSelectionSort(new SortByYearAscending());
            Assert.IsTrue(CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void SelectionSortCarSortByYearDescendingTest()
        {
            var sortedList = cars.SortWithSelectionSort(new SortByYearDescending());
            Assert.IsTrue(CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void SelectionSortCarSortByDefaultTest()
        {
            var sortedList = cars.SortWithSelectionSort();
            Assert.IsTrue(CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void SelectionSortCarSortByMakeDescendingTest()
        {
            var sortedList = cars.SortWithSelectionSort(new SortByMakeDescending());
            Assert.IsTrue(CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void SelectionSortIntegerTest()
        {
            var sortedList = integers.SortWithSelectionSort();
            Assert.IsTrue(CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void SelectionSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithSelectionSort(2, 6, Comparer<int>.Default);
            Assert.IsTrue(CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void SelectionSortStringTest()
        {
            var sortedList = greekAlphabet.SortWithSelectionSort();
            Assert.IsTrue(CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void SelectionSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithSelectionSort();
            Assert.IsTrue(CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region InsertionSort Tests

        [TestMethod]
        public void InsertionSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithInsertionSort(new SortByYearAscending());
            Assert.IsTrue(CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void InsertionSortCarSortByYearDescendingTest()
        {
            var sortedList = cars.SortWithInsertionSort(new SortByYearDescending());
            Assert.IsTrue(CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void InsertionSortCarSortByDefaultTest()
        {
            var sortedList = cars.SortWithInsertionSort();
            Assert.IsTrue(CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void InsertionSortCarSortByMakeDescendingTest()
        {
            var sortedList = cars.SortWithInsertionSort(new SortByMakeDescending());
            Assert.IsTrue(CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void InsertionSortIntegerTest()
        {
            var sortedList = integers.SortWithInsertionSort();
            Assert.IsTrue(CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void InsertionSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithInsertionSort(2, 6, Comparer<int>.Default);
            Assert.IsTrue(CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void InsertionSortStringTest()
        {
            var sortedList = greekAlphabet.SortWithInsertionSort();
            Assert.IsTrue(CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void InsertionSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithInsertionSort();
            Assert.IsTrue(CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region HeapSort Tests

        [TestMethod]
        public void HeapSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithHeapSort(new SortByYearAscending());
            Assert.IsTrue(CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortCarSortByYearDescendingTest()
        {
            var sortedList = cars.SortWithHeapSort(new SortByYearDescending());
            Assert.IsTrue(CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortCarSortByDefaultTest()
        {
            var sortedList = cars.SortWithHeapSort();
            Assert.IsTrue(CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortCarSortByMakeDescendingTest()
        {
            var sortedList = cars.SortWithHeapSort(new SortByMakeDescending());
            Assert.IsTrue(CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortIntegerTest()
        {
            var sortedList = integers.SortWithHeapSort();
            Assert.IsTrue(CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortIntegerRangeTest()
        {
            var sortedList = integers.SortWithHeapSort(2, 6, Comparer<int>.Default);
            Assert.IsTrue(CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortStringTest()
        {
            var sortedList = greekAlphabet.SortWithHeapSort();
            Assert.IsTrue(CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void HeapSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithHeapSort();
            Assert.IsTrue(CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region MergeSort Tests

        [TestMethod]
        public void MergeSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithMergeSort(new SortByYearAscending());
            Assert.IsTrue(CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortCarSortByYearDescendingTest()
        {
            var sortedList = cars.SortWithMergeSort(new SortByYearDescending());
            Assert.IsTrue(CheckCarsSortByYearDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortCarSortByDefaultTest()
        {
            var sortedList = cars.SortWithMergeSort();
            Assert.IsTrue(CheckCarsSortByMakeAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortCarSortByMakeDescendingTest()
        {
            var sortedList = cars.SortWithMergeSort(new SortByMakeDescending());
            Assert.IsTrue(CheckCarsSortByMakeDescending(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortIntegerTest()
        {
            var sortedList = integers.SortWithMergeSort();
            Assert.IsTrue(CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortIntegerRangeTest()
        {
           var sortedList = integers.SortWithMergeSort(2, 6, Comparer<int>.Default);
           Assert.IsTrue(CheckIntegerRangeList(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortStringTest()
        {
            var sortedList = greekAlphabet.SortWithMergeSort();
            Assert.IsTrue(CheckAlphabet(sortedList.ToList()));
        }

        [TestMethod]
        public void MergeSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithMergeSort();
            Assert.IsTrue(CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        #region CountingSort Tests

        [TestMethod]
        public void CountingSortCarSortByYearAscendingTest()
        {
            var sortedList = cars.SortWithCountingSort(car => car.Year);
            Assert.IsTrue(CheckCarsSortByYearAscending(sortedList.ToList()));
        }

        [TestMethod]
        public void CountingSortIntegerTest()
        {
            var sortedList = integers.SortWithCountingSort();
            Assert.IsTrue(CheckIntegerList(sortedList.ToList()));
        }

        [TestMethod]
        public void CountingSortRandomIntegerTest()
        {
            var sortedList = randomIntegers.SortWithCountingSort();
            Assert.IsTrue(CheckRandomIntegerList(sortedList.ToList()));
        }

        #endregion

        [TestMethod]
        public void Probieren()
        {
            List<int> ints = new()
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

            //randomIntegers.Sort();
            //Assert.IsTrue(CheckRandomIntegerList(randomIntegers.ToList()));
            //ints.Sort()
            //ints.SortWithBubbleSort()

            //var merge = ints.SortWithMergeSort();

            //string test = "";
        }


    }
}