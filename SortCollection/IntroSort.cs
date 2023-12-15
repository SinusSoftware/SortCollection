namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class IntroSort
    {
        #region Ascending 

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// This algorithm use insertionsort, heapsort and quicksort
        /// Stable: No
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithIntroSort<T>(this IEnumerable<T> source)
        {
            return SortWithIntrosort(source, 0, source.Count(), Comparer<T>.Default, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// This algorithm use insertionsort, heapsort and quicksort
        /// Stable: No
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithIntroSort<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithIntrosort(source, index, count, Comparer<T>.Default, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm use insertionsort, heapsort and quicksort
        /// Stable: No
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithIntroSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithIntrosort(source, 0, source.Count(), comparer, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm use insertionsort, heapsort and quicksort
        /// Stable: No
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/>
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithIntroSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithIntrosort(source, index, count, comparer, false);
        }

        #endregion

        #region Descending

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// This algorithm use insertionsort, heapsort and quicksort
        /// Stable: No
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithIntroSortDescending<T>(this IEnumerable<T> source)
        {
            return SortWithIntrosort(source, 0, source.Count(), Comparer<T>.Default, true);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// This algorithm use insertionsort, heapsort and quicksort
        /// Stable: No
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithIntroSortDescending<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithIntrosort(source, index, count, Comparer<T>.Default, true);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm use insertionsort, heapsort and quicksort
        /// Stable: No
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithIntroSortDescending<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithIntrosort(source, 0, source.Count(), comparer, true);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm use insertionsort, heapsort and quicksort
        /// Stable: No
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/>
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithIntroSortDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithIntrosort(source, index, count, comparer, true);
        }

        #endregion

        private static IEnumerable<T> SortWithIntrosort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer, bool descending)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index), index, "The index can't be less than 0.");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), count, "The count can't be less than 0.");
            }

            if (source.Count() - index < count)
            {
                throw new ArgumentException("Count must be greater than number of elemets in source minus index");
            }

            T[] partitionSort = source.ToArray();

            int order = descending ? -1 : 1;

            int partitionSize = Partition(ref partitionSort, index, count - 1, comparer, order);
            

            if (descending)
            {
                if (partitionSize < 16)
                {
                    return InsertionSort.SortWithInsertionSortDescending(source, index, count, comparer);
                }
                else if (partitionSize > (2 * Math.Log(partitionSort.Length)))
                {
                    return HeapSort.SortWithHeapSortDescending(source, index, count, comparer);
                }
            }
            else
            {
                if (partitionSize < 16)
                {
                    return InsertionSort.SortWithInsertionSort(source, index, count, comparer);
                }
                else if (partitionSize > (2 * Math.Log(partitionSort.Length)))
                {
                    return HeapSort.SortWithHeapSort(source, index, count, comparer);
                }
            }

            T[] sortMeQuickSort = source.ToArray();
            QuickSort(ref sortMeQuickSort, index, count + index - 1, comparer, order);
            return sortMeQuickSort;
        }

        private static void QuickSort<T>(ref T[] input, int left, int right, IComparer<T> comparer, int order)
        {
            if (left < right)
            {
                int q = Partition(ref input, left, right, comparer, order);
                QuickSort(ref input, left, q - 1, comparer, order);
                QuickSort(ref input, q + 1, right, comparer, order);
            }
        }

        private static int Partition<T>(ref T[] input, int left, int right, IComparer<T> comparer, int order)
        {
            T pivot = input[right];
            T temp;
            int i = left;

            for (int j = left; j < right; ++j)
            {
                //else if (comparer.Compare(sortProperty(leftArray[i]), sortProperty(rightArray[j])) == order || comparer.Compare(sortProperty(leftArray[i]), sortProperty(rightArray[j])) == 0)
                //else if (comparer.Compare(sortProperty(leftArray[i]), sortProperty(rightArray[j])) == order || comparer.Compare(sortProperty(leftArray[i]), sortProperty(rightArray[j])) == 0)
                //if (comparer.Compare(input[j], pivot) <= 0)
                if (comparer.Compare(input[j], pivot) == order || comparer.Compare(input[j], pivot) == 0)
                {
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[right] = input[i];
            input[i] = pivot;

            return i;
        }

    }
}
