﻿namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class BubbleSort
    {
        #region Ascending

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
        /// Stable: Yes
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSort<T>(this IEnumerable<T> source)
        {
            return SortWithBubbleSort(source, 0, source.Count(), Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSort<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithBubbleSort(source, index, count, Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithBubbleSort(source, 0, source.Count(), comparer, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n)<br/>
        /// Average Time Complexity[Big - theta]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
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
        public static IEnumerable<T> SortWithBubbleSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithBubbleSort(source, index, count, comparer, source => source, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithBubbleSortBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithBubbleSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithBubbleSortBy<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithBubbleSort(source, index, count, Comparer<TKey>.Default, sortProperty, false);
        }

        #endregion

        #region Descending

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSortDescending<T>(this IEnumerable<T> source)
        {
            return SortWithBubbleSort(source, 0, source.Count(), Comparer<T>.Default, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSortDescending<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithBubbleSort(source, index, count, Comparer<T>.Default, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSortDescending<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithBubbleSort(source, 0, source.Count(), comparer, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSortDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithBubbleSort(source, index, count, comparer, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithBubbleSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithBubbleSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithBubbleSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithBubbleSort(source, index, count, Comparer<TKey>.Default, sortProperty, true);
        }

        #endregion

        private static IEnumerable<TSource> SortWithBubbleSort<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, bool descending)
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
            int order = descending ? -1 : 1;
            TSource[] sortMe = source.ToArray();

            for (int i = 1; i < count + index; i++)
            {
                for (int j = index; j < (count + index - i); j++)
                {
                    if (comparer.Compare(sortProperty(sortMe[j]), sortProperty(sortMe[j + 1])) == order)
                    {
                        TSource temp = sortMe[j];
                        sortMe[j] = sortMe[j + 1];
                        sortMe[j + 1] = temp;
                    }
                }
            }

            return sortMe;
        }
    }
}
