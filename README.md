# SortCollection
SortCollection is a dll with different sorting algorithms. Currently supported:  
* Bubblesort
* Selectionsort 
* Insertionsort 
* Heapsort 
* Mergesort
* Countingsort
* Shellsort with different gap sequences
* Radixsort
* Slowsort
* Introsort
* Timsort

## Installation
Use the package manager [Nuget](https://www.nuget.org/packages/SinusSoftware.SortCollection) to install SortCollection.


## Usage

 ```csharp

public class SortDescending : IComparer<int>
{
    public int Compare(int a, int b)
    {
        if (a > b)
            return -1;

        if (a < b)
            return 1;

        else
            return 0;
    }
}

public class Car
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
}

List<int> integers = new()
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


List<Car>() cars = new()
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

# Example Bubblesort
var bubbleSortedList = integers.SortWithBubbleSort();

# Example Selectionsort with customcompare
var selectionSortedList = integers.SortWithSelectionSort(new SortDescending());

# Example Insertionsort with range
var insertionSortedList = integers.SortWithInsertionSort(2, 6);

# Example Heapsort with range and customcompare
var heapSortedList = integers.SortWithHeapSort(2, 6, new SortDescending());


# Example Contingsort with Object "Car"
var sortedList = cars.SortWithCountingSort(car => car.Year);

```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)