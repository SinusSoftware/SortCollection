namespace System
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class MergeSort
    {

        #region Ascending

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n* log n)
        /// Best Case Time Complexity[Big - omega]: O(n* log n)
        /// Average Time Complexity[Big - theta]: O(n* log n)
        /// Space Complexity: O(n)
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithMergeSort<T>(this IEnumerable<T> source)
        {
            return SortWithMergeSort(source, 0, source.Count(), Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n* log n)
        /// Best Case Time Complexity[Big - omega]: O(n* log n)
        /// Average Time Complexity[Big - theta]: O(n* log n)
        /// Space Complexity: O(n)
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithMergeSort<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithMergeSort(source, index, count, Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n* log n)
        /// Best Case Time Complexity[Big - omega]: O(n* log n)
        /// Average Time Complexity[Big - theta]: O(n* log n)
        /// Space Complexity: O(n)
        /// Stable: Yes
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithMergeSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithMergeSort(source, 0, source.Count(), comparer, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n* log n)
        /// Best Case Time Complexity[Big - omega]: O(n* log n)
        /// Average Time Complexity[Big - theta]: O(n* log n)
        /// Space Complexity: O(n)
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/>
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithMergeSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithMergeSort(source, index, count, comparer, source => source, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithMergeSortBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithMergeSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithMergeSortBy<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithMergeSort(source, index, count, Comparer<TKey>.Default, sortProperty, false);
        }

        #endregion

        #region Descending

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithMergeSortDescending<T>(this IEnumerable<T> source)
        {
            return SortWithMergeSort(source, 0, source.Count(), Comparer<T>.Default, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithMergeSortDescending<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithMergeSort(source, index, count, Comparer<T>.Default, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithMergeSortDescending<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithMergeSort(source, 0, source.Count(), comparer, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithMergeSortDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithMergeSort(source, index, count, comparer, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithMergeSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithMergeSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithMergeSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithMergeSort(source, index, count, Comparer<TKey>.Default, sortProperty, true);
        }

        #endregion

        private static IEnumerable<TSource> SortWithMergeSort<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, bool descending)
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
            int order = descending ? 1 : -1;

            TSource[] sortMe = source.ToArray();
            Mergesort(sortMe, index, count - 1 + index, comparer, sortProperty, order);
            return sortMe;
        }

        private static void Mergesort<TSource, TKey>(TSource[] input, int left, int right, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                Mergesort(input, left, middle, comparer, sortProperty, order);
                Mergesort(input, middle + 1, right, comparer, sortProperty, order);

                Merge(input, left, middle, right, comparer, sortProperty, order);
            }
        }

        private static void Merge<TSource, TKey>(TSource[] input, int left, int middle, int right, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            TSource[] leftArray = new TSource[middle - left + 1];
            TSource[] rightArray = new TSource[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (comparer.Compare(sortProperty(leftArray[i]), sortProperty(rightArray[j])) == order || comparer.Compare(sortProperty(leftArray[i]), sortProperty(rightArray[j])) == 0)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }
    }
}
