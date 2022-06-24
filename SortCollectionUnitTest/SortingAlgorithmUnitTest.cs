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
            //ints.Sort()
            //ints.SortWithBubbleSort()

            //var merge = ints.SortWithMergeSort();

            string test = "";
        }


        [TestMethod]
        public void IntegerSortTest()
        {
           
            var insertion = integers.SortWithInsertionSort();
            Assert.IsTrue(CheckIntegerList(insertion.ToList()));
            var heap = integers.SortWithHeapSort();
            Assert.IsTrue(CheckIntegerList(heap.ToList()));
            var merge = integers.SortWithMergeSort();
            Assert.IsTrue(CheckIntegerList(merge.ToList()));
            var counting = integers.SortWithCountingSort();
            Assert.IsTrue(CheckIntegerList(counting.ToList()));
        }


        [TestMethod]
        public void StringSortTest()
        {
           
           
            var insertion = greekAlphabet.SortWithInsertionSort();
            Assert.IsTrue(CheckAlphabet(insertion.ToList()));
            var heap = greekAlphabet.SortWithHeapSort();
            Assert.IsTrue(CheckAlphabet(heap.ToList()));
            var merge = greekAlphabet.SortWithMergeSort();
            Assert.IsTrue(CheckAlphabet(merge.ToList()));
        }


        [TestMethod]
        public void RandomIntegerSortTest()
        {

          
            var insertion = randomIntegers.SortWithInsertionSort();
            Assert.IsTrue(CheckRandomIntegerList(insertion.ToList()));
            var heap = randomIntegers.SortWithHeapSort();
            Assert.IsTrue(CheckRandomIntegerList(heap.ToList()));
            var merge = randomIntegers.SortWithMergeSort();
            Assert.IsTrue(CheckRandomIntegerList(merge.ToList()));
            var counting = randomIntegers.SortWithCountingSort();
            Assert.IsTrue(CheckRandomIntegerList(counting.ToList()));
        }


    }
}