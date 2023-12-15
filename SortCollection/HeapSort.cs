namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class HeapSort
    {
        #region Ascending

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst case time O(nlg⁡n)O
        /// Best case time O(n)
        /// Average case time O(nlg⁡n)
        /// Space O(1)
        /// Stable: No
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithHeapSort<T>(this IEnumerable<T> source)
        {
            return SortWithHeapSort(source, 0, source.Count(), Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst case time O(nlg⁡n)O
        /// Best case time O(n)
        /// Average case time O(nlg⁡n)
        /// Space O(1)
        /// Stable: No
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithHeapSort<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithHeapSort(source, index, count, Comparer<T>.Default, source => source, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithHeapSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithHeapSort(source, 0, source.Count(), comparer, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst case time O(nlg⁡n)O
        /// Best case time O(n)
        /// Average case time O(nlg⁡n)
        /// Space O(1)
        /// Stable: No
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithHeapSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithHeapSort(source, index, count, comparer, source => source, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithHeapSortBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithHeapSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithHeapSortBy<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithHeapSort(source, index, count, Comparer<TKey>.Default, sortProperty, false);
        }

        #endregion

        #region Descending

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithHeapSortDescending<T>(this IEnumerable<T> source)
        {
            return SortWithHeapSort(source, 0, source.Count(), Comparer<T>.Default, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithHeapSortDescending<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithHeapSort(source, index, count, Comparer<T>.Default, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithHeapSortDescending<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithHeapSort(source, 0, source.Count(), comparer, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithHeapSortDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithHeapSort(source, index, count, comparer, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithHeapSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithHeapSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithHeapSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithHeapSort(source, index, count, Comparer<TKey>.Default, sortProperty, true);
        }

        #endregion

        public static IEnumerable<TSource> SortWithHeapSort<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, bool descending)
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

            comparer ??= Comparer<TKey>.Default;
            int order = descending ? -1 : 1;
            var sortMe = source.ToArray();
            int rangeLength = count + index;

            for (int i = count / 2; i >= 0; --i)
            {
                Heapify(sortMe, rangeLength, i, index, comparer, sortProperty, order);
            }
            for (int i = rangeLength - 1; i > index; --i)
            {
                var swap = sortMe[index];
                sortMe[index] = sortMe[i];
                sortMe[i] = swap;
                Heapify(sortMe, i, 0, index, comparer, sortProperty, order);
            }

            return sortMe;
        }

        private static void Heapify<TSource, TKey>(TSource[] sortMe, int n, int i, int index, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left + index < n && comparer.Compare(sortProperty(sortMe[left + index]), sortProperty(sortMe[largest + index])) == order)
                largest = left;
            if (right + index < n && comparer.Compare(sortProperty(sortMe[right + index]), sortProperty(sortMe[largest + index])) == order)
                largest = right;
            if (largest != i)
            {
                var swap = sortMe[i + index];
                sortMe[i + index] = sortMe[largest + index];
                sortMe[largest + index] = swap;
                Heapify(sortMe, n, largest, index, comparer, sortProperty, order);
            }
        }
    }
}
