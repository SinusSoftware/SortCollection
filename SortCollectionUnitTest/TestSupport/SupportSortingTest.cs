using System;
using System.Collections.Generic;

namespace SortCollectionUnitTest
{
    public class SupportSortingTest
    {

        #region integer

        public static List<int> GenerateSmallIntegers()
        {
            return new()
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
        }

        public static List<Car> GenerateCars()
        {
            return new List<Car>()
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

        public static bool CheckIntegerList(IList<int> values)
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

        public static bool CheckIntegerRangeList(IList<int> values)
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

        public static bool CheckRandomIntegerList(IList<int> values)
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

        public static bool CheckCarsSortByYearAscending(IList<Car> cars)
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

        public static bool CheckCarsSortByYearDescending(IList<Car> cars)
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

        #endregion integer

        #region unsigend integer

        public static List<uint> GenerateSmallUInt()
        {
            return new()
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
        }

        public static List<CarUInt> GenerateCarsUInt()
        {
            return new List<CarUInt>()
            {
                 new CarUInt("Ford",1992),
                 new CarUInt("Fiat",1988),
                 new CarUInt("Buick",1932),
                 new CarUInt("VW", 2020),
                 new CarUInt("Renault",2015),
                 new CarUInt("Toyota",2006),
                 new CarUInt("Nissan",2018),
                 new CarUInt("Dodge",1999),
                 new CarUInt("Honda",1977)
             };
        }

        public static uint[] CreateRandomArrayUInt(int size, int lower, int upper)
        {
            var array = new uint[size];
            var rand = new Random();
            for (int i = 0; i < size; i++)
                array[i] = (uint)rand.Next(lower, upper);
            return array;
        }

        public static bool CheckIntegerListUInt(IList<uint> values)
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

        public static bool CheckRandomIntegerListUInt(IList<uint> values)
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

        public static bool CheckCarsSortByYearAscendingUInt(IList<CarUInt> cars)
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

        #endregion unsigend

        #region string

        public static List<string> GenerateGreekAlphabet()
        {
            return new()
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
        }

        public static bool CheckAlphabet(IList<string> values)
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

        public static bool CheckCarsSortByMakeAscending(IList<Car> cars)
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

        public static bool CheckCarsSortByMakeDescending(IList<Car> cars)
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

        #endregion
    }
}
