using System;
using System.Collections.Generic;

namespace SortCollectionUnitTest
{
    public class SortByYearAscending : IComparer<Car>
    {
        public int Compare(Car? a, Car? b)
        {
            if (a == null || b == null)
            {
                throw new InvalidCastException();
            }

            if (a.Year > b.Year)
                return 1;

            if (a.Year < b.Year)
                return -1;

            else
                return 0;
        }
    }

    public class SortByYearDescending : IComparer<Car>
    {
        public int Compare(Car? a, Car? b)
        {
            if (a == null || b == null)
            {
                throw new InvalidCastException();
            }

            if (a.Year > b.Year)
                return -1;

            if (a.Year < b.Year)
                return 1;

            else
                return 0;
        }
    }

    public class SortByMakeDescending : IComparer<Car>
    {
        public int Compare(Car? a, Car? b)
        {
            if (a == null || b == null)
            {
                throw new InvalidCastException();
            }

            return string.Compare(b.Make, a.Make);
        }

    }
}
