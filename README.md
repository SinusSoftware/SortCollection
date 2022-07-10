# SortCollection
SortCollection is a dll with different sorting algorithms. Currently supported:  
* Bubblesort
* Selectionsort 
* Insertionsort 
* Heapsort 
* Mergesort
* Countingsort

## Installation
Use the package manager [Nuget](https://www.nuget.org/) to install SortCollection.


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



# Example Bubblesort
var bubbleSortedList = integers.SortWithBubbleSort();

# Example Heapsort with range and default comparer
var heapSortedList = integers.SortWithHeapSort(2, 6, Comparer<int>.Default);

# Example Selectionsort with customcompare
var selectionSortedList = integers.SortWithSelectionSort(new SortDescending());
```

## Contributing
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License
[MIT](https://choosealicense.com/licenses/mit/)