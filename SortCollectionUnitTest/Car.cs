namespace SortCollectionUnitTest
{
    public class Car : IComparable
    {
        private int year;
        private string make;

        public Car(string make, int year)
        {
            this.make = make;
            this.year = year;
        }

        public int Year
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
            return string.Compare(this.Make, car.Make);
        }
    }
}
