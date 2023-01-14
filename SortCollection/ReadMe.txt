=== SortCollection ===

Author: Dirk Tamke
eMail: SinusSoftware@gmx.net
GitHub URI: https://github.com/SinusSoftware/SortCollection
License: MIT
License URI: https://choosealicense.com/licenses/mit/


== Description ==

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

Example:
var heapSortedList = list.SortWithHeapSort();

== Changelog ==

= 1.2 =
* Add Slowsort
* Add Introsort
* Add Timsort
* Add Function '...Sort(index, count)' for all sorting algorithms.
* Add Enum 'GroupBitLength' for Radixsort.

= 1.1 =
* Add Shellsort with following gap sequences:
      Shell
      Hibbard
      Papernov and Stasevich
      Pratt
      Knuth
      Incerpi and Sedgewick
      Sedgewick from year 1982
      Sedgewick from year 1986
      Tokuda
      Ciura
* Add Radixsort
* Add Targetframework .Net7.0

= 1.0 =
* First version
