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
    public static partial class ParallelQuickSort
    {

        #region Ascending

        /// <summary>
        /// 
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelQuickSort<T>(this IEnumerable<T> source)
        {
            return SortWithParallelQuickSort(source, 0, source.Count(), Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelQuickSort<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithParallelQuickSort(source, index, count, Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelQuickSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithParallelQuickSort(source, 0, source.Count(), comparer, source => source, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelQuickSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithParallelQuickSort(source, index, count, comparer, source => source, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithParallelQuickSortBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithParallelQuickSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithParallelQuickSortBy<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithParallelQuickSort(source, index, count, Comparer<TKey>.Default, sortProperty, false);
        }

        #endregion

        #region Descending

        /// <summary>
        /// 
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelQuickSortDescending<T>(this IEnumerable<T> source)
        {
            return SortWithParallelQuickSort(source, 0, source.Count(), Comparer<T>.Default, source => source, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelQuickSortDescending<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithParallelQuickSort(source, index, count, Comparer<T>.Default, source => source, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelQuickSortDescending<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithParallelQuickSort(source, 0, source.Count(), comparer, source => source, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelQuickSortDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithParallelQuickSort(source, index, count, comparer, source => source, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithParallelQuickSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithParallelQuickSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithParallelQuickSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithParallelQuickSort(source, index, count, Comparer<TKey>.Default, sortProperty, true);
        }

        #endregion

        private static IEnumerable<TSource> SortWithParallelQuickSort<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, bool descending)
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
                throw new ArgumentException("Count must be greater than number of elements in source minus index");
            }


            comparer ??= Comparer<TKey>.Default;
            int order = descending ? 1 : -1;
            TSource[] sortMe = source.ToArray();

            int startIndex = index;
            int endIndex = index + count - 1;

            QuickSortParallel(sortMe, startIndex, endIndex, 0, comparer, sortProperty, order);

            return sortMe;
        }

        private static void QuickSortParallel<TSource, TKey>(TSource[] array, int startIndex, int endIndex, int depth, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            if (startIndex >= endIndex)
                return;

            int pivotIndex = QuickSort.Partition(ref array, startIndex, endIndex, comparer, sortProperty, order);

            if (depth < Environment.ProcessorCount)
            {
                Parallel.Invoke(
                    () => QuickSortParallel(array, startIndex, pivotIndex - 1, depth + 1, comparer, sortProperty, order),
                    () => QuickSortParallel(array, pivotIndex + 1, endIndex, depth + 1, comparer, sortProperty, order)
                );
            }
            else
            {
                QuickSortSequential(array, startIndex, pivotIndex - 1, depth, comparer, sortProperty, order);
                QuickSortSequential(array, pivotIndex + 1, endIndex, depth, comparer, sortProperty, order);
            }
        }

        private static void QuickSortSequential<TSource, TKey>(TSource[] array, int startIndex, int endIndex, int depth, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            if (startIndex >= endIndex)
                return;

            int pivotIndex = QuickSort.Partition(ref array, startIndex, endIndex, comparer, sortProperty, order);
            QuickSortSequential(array, startIndex, pivotIndex - 1, depth, comparer, sortProperty, order);
            QuickSortSequential(array, pivotIndex + 1, endIndex, depth, comparer, sortProperty, order);
        }
    }
}

