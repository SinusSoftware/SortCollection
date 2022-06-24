namespace SortCollectionUnitTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class UnitTest1
    {


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

            var merge = ints.SortWithMergeSort();

            string test = "";
        }


        public static int[] CreateRandomArray(int size, int lower, int upper)
        {
            var array = new int[size];
            var rand = new Random();
            for (int i = 0; i < size; i++)
                array[i] = rand.Next(lower, upper);
            return array;
        }

        [TestMethod]
        public void IntegerSortTest()
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

            var bubble = ints.SortWithBubbleSort();
            Assert.IsTrue(CheckIntegerList(bubble.ToList()));
            var selection = ints.SortWithSelectionSort();
            Assert.IsTrue(CheckIntegerList(selection.ToList()));
            var insertion = ints.SortWithInsertionSort();
            Assert.IsTrue(CheckIntegerList(insertion.ToList()));
            var heap = ints.SortWithHeapSort();
            Assert.IsTrue(CheckIntegerList(heap.ToList()));
            var merge = ints.SortWithMergeSort();
            Assert.IsTrue(CheckIntegerList(merge.ToList()));
            var counting = ints.SortWithCountingSort();
            Assert.IsTrue(CheckIntegerList(counting.ToList()));
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

        [TestMethod]
        public void StringSortTest()
        {
            List<string> ints = new()
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

            var bubble = ints.SortWithBubbleSort();
            Assert.IsTrue(CheckAlphabet(bubble.ToList()));
            var selection = ints.SortWithSelectionSort();
            Assert.IsTrue(CheckAlphabet(selection.ToList()));
            var insertion = ints.SortWithInsertionSort();
            Assert.IsTrue(CheckAlphabet(insertion.ToList()));
            var heap = ints.SortWithHeapSort();
            Assert.IsTrue(CheckAlphabet(heap.ToList()));
            var merge = ints.SortWithMergeSort();
            Assert.IsTrue(CheckAlphabet(merge.ToList()));
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

        [TestMethod]
        public void RandomIntegerSortTest()
        {
            var rand = new Random();
            var rtnlist = new List<int>();

            for (int i = 0; i < 10000; i++)
            {
                rtnlist.Add(rand.Next(10000));
            }


            var bubble = rtnlist.SortWithBubbleSort();
            Assert.IsTrue(CheckRandomIntegerList(bubble.ToList()));
            var selection = rtnlist.SortWithSelectionSort();
            Assert.IsTrue(CheckRandomIntegerList(selection.ToList()));
            var insertion = rtnlist.SortWithInsertionSort();
            Assert.IsTrue(CheckRandomIntegerList(insertion.ToList()));
            var heap = rtnlist.SortWithHeapSort();
            Assert.IsTrue(CheckRandomIntegerList(heap.ToList()));
            var merge = rtnlist.SortWithMergeSort();
            Assert.IsTrue(CheckRandomIntegerList(merge.ToList()));
            var counting = rtnlist.SortWithCountingSort();
            Assert.IsTrue(CheckRandomIntegerList(counting.ToList()));
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
    }
}