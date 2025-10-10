namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class TimSort
    {

        #region Ascending

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithTimSort<T>(this IEnumerable<T> source)
        {
            return SortWithTimSort(source, 0, source.Count(), Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        public static IEnumerable<T> SortWithTimSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithTimSort(source, 0, source.Count(), comparer, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithTimSort<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithTimSort(source, index, count, Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithTimSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithTimSort(source, index, count, comparer, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithTimSortBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithTimSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithTimSortBy<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithTimSort(source, index, count, Comparer<TKey>.Default, sortProperty, false);
        }

        #endregion

        #region Descending

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithTimSortDescending<T>(this IEnumerable<T> source)
        {
            return SortWithTimSort(source, 0, source.Count(), Comparer<T>.Default, source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        public static IEnumerable<T> SortWithTimSortDescending<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithTimSort(source, 0, source.Count(), comparer, source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithTimSortDescending<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithTimSort(source, index, count, Comparer<T>.Default, source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithTimSortDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithTimSort(source, index, count, comparer, source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithTimSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithTimSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, true);
        }

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithTimSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithTimSort(source, index, count, Comparer<TKey>.Default, sortProperty, true);
        }

        #endregion

        private static IEnumerable<TSource> SortWithTimSort<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, bool descending)
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

            IEnumerable<TSource> arr = source.ToArray();

            int n = count + index;
            for (int i = 0 + index; i < n; i += RUN)
            {
                arr = InsertionSort.SortWithInsertionSort(arr, i, Math.Min(n - i, RUN), comparer, sortProperty, descending);
            }

            TSource[] arr2 = arr.ToArray();
            for (int size = RUN; size < n; size = 2 * size)
            {
                for (int left = 0 + index; left < n; left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = Math.Min(left + 2 * size - 1, n - 1);

                    if (mid < right)
                    {
                        MergeSort.Merge(arr2, left, mid, right, comparer, sortProperty, order);
                    }
                }
            }

            return arr2;
        }

        /// <summary>
        /// RUN = 32
        /// </summary>
        public const int RUN = 32;

        /*
        private static void Merge<T>(T[] input, int left, int middle, int right, IComparer<T> comparer, int order)
        {
            T[] leftArray = new T[middle - left + 1];
            T[] rightArray = new T[right - middle];

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
                else if (comparer.Compare(leftArray[i], rightArray[j]) == order || comparer.Compare(leftArray[i], rightArray[j]) == 0)
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

        */

        /*
       
        private static T[] SortWithTimsort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer, bool descending)
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

            comparer ??= Comparer<T>.Default;
            int order = descending ? 1 : -1;

            IEnumerable<T> arr = source.ToArray();

            int n = count + index;
            for (int i = 0 + index; i < n; i += RUN)
            {
                if (descending)
                {
                    arr = InsertionSort.SortWithInsertionSortDescending(arr, i, Math.Min(n - i, RUN), comparer);
                }
                else
                {
                    arr = InsertionSort.SortWithInsertionSort(arr, i, Math.Min(n - i, RUN), comparer);
                }
            }

            T[] arr2 = arr.ToArray();
            for (int size = RUN; size < n; size = 2 * size)
            {
                for (int left = 0 + index; left < n; left += 2 * size)
                {
                    int mid = left + size - 1;
                    int right = Math.Min(left + 2 * size - 1, n - 1);

                    if (mid < right)
                    {
                        Merge(arr2, left, mid, right, comparer, order);
                    }
                }
            }

            return arr2;
        }

        public const int RUN = 32;

        private static void Merge<T>(T[] input, int left, int middle, int right, IComparer<T> comparer, int order)
        {
            T[] leftArray = new T[middle - left + 1];
            T[] rightArray = new T[right - middle];

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
                else if (comparer.Compare(leftArray[i], rightArray[j]) == order || comparer.Compare(leftArray[i], rightArray[j]) == 0)
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

        */
    }
}
