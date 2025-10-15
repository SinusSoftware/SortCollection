namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading.Tasks;


    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class ParallelMergeSort
    {

        #region Ascending

        /// <summary>
        /// Sorts the elements multithreading in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithParallelMergeSort<TSource>(this IEnumerable<TSource> source)
        {
            return SortWithParallelMergeSort(source, 0, source.Count(), Comparer<TSource>.Default, source => source, false);
        }

        /// <summary>
        /// Sorts the elements multithreading in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelMergeSort<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithParallelMergeSort(source, index, count, Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// Sorts the elements multithreading in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelMergeSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithParallelMergeSort(source, 0, source.Count(), comparer, source => source, false);
        }


        /// <summary>
        /// Sorts the elements multithreading in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
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
        public static IEnumerable<T> SortWithParallelMergeSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithParallelMergeSort(source, index, count, comparer, source => source, false);
        }

        /// <summary>
        /// Sorts the elements multithreading in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithParallelMergeSortBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithParallelMergeSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false);
        }

        /// <summary>
        /// Sorts the elements multithreading in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
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
        public static IEnumerable<TSource> SortWithParallelMergeSortBy<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithParallelMergeSort(source, index, count, Comparer<TKey>.Default, sortProperty, false);
        }

        #endregion

        #region Descending

        /// <summary>
        /// Sorts the elements descending and multithreading in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelMergeSortDescending<T>(this IEnumerable<T> source)
        {
            return SortWithParallelMergeSort(source, 0, source.Count(), Comparer<T>.Default, source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending and multithreading in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelMergeSortDescending<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithParallelMergeSort(source, index, count, Comparer<T>.Default, source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending and multithreading in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelMergeSortDescending<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithParallelMergeSort(source, 0, source.Count(), comparer, source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending and multithreading in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
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
        public static IEnumerable<T> SortWithParallelMergeSortDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithParallelMergeSort(source, index, count, comparer, source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending and multithreading in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithParallelMergeSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithParallelMergeSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, true);
        }

        /// <summary>
        /// Sorts the elements descending and multithreading in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithParallelMergeSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithParallelMergeSort(source, index, count, Comparer<TKey>.Default, sortProperty, true);
        }

        #endregion

        private static IEnumerable<TSource> SortWithParallelMergeSort<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, bool descending)
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
            MergeSortParallel(sortMe, index, count - 1 + index, 0, comparer, sortProperty, order);
            return sortMe;
        }

        private static void MergeSortParallel<TSource, TKey>(TSource[] array, int left, int right, int depth, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;

            if (depth < Environment.ProcessorCount)
            {
                Parallel.Invoke(
                    () => MergeSortParallel(array, left, middle, depth + 1, comparer, sortProperty, order),
                    () => MergeSortParallel(array, middle + 1, right, depth + 1, comparer, sortProperty, order)
                );
            }
            else
            {
                MergeSortSequential(array, left, middle, comparer, sortProperty, order);
                MergeSortSequential(array, middle + 1, right, comparer, sortProperty, order);
            }

            MergeSort.Merge(array, left, middle, right, comparer, sortProperty, order);
        }

        private static void MergeSortSequential<TSource, TKey>(TSource[] array, int left, int right, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;
            MergeSortSequential(array, left, middle, comparer, sortProperty, order);
            MergeSortSequential(array, middle + 1, right, comparer, sortProperty, order);
            MergeSort.Merge(array, left, middle, right, comparer, sortProperty, order);
        }
    }
}
