using System;

namespace SortCollectionUnitTest
{
    public class CarUInt : IComparable
    {
        private uint year;
        private string make;

        public CarUInt(string make, uint year)
        {
            this.make = make;
            this.year = year;
        }

        public uint Year
        {
            get { return year; }
            set { year = value; }
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        //default compare
        public int CompareTo(object? obj)
        {
            if (obj is not Car car)
            {
                throw new InvalidCastException(nameof(obj));
            }
            return string.Compare(Make, car.Make);
        }
    }
}
