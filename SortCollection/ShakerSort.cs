namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class ShakerSort
    {
        #region Ascending

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSort<T>(this IEnumerable<T> source)
        {
            return SortWithShakerSort(source, 0, source.Count(), Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSort<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithShakerSort(source, index, count, Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithShakerSort(source, 0, source.Count(), comparer, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
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
        public static IEnumerable<T> SortWithShakerSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithShakerSort(source, index, count, comparer, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithShakerSortBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithShakerSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithShakerSortBy<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithShakerSort(source, index, count, Comparer<TKey>.Default, sortProperty, false);
        }

        #endregion

        #region Descending

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSortDescending<T>(this IEnumerable<T> source)
        {
            return SortWithShakerSort(source, 0, source.Count(), Comparer<T>.Default, source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSortDescending<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithShakerSort(source, index, count, Comparer<T>.Default, source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSortDescending<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithShakerSort(source, 0, source.Count(), comparer, source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
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
        public static IEnumerable<T> SortWithShakerSortDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithShakerSort(source, index, count, comparer, source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithShakerSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithShakerSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, true);
        }

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n^2)<br/>
        /// Space Complexity: O(1)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithShakerSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithShakerSort(source, index, count, Comparer<TKey>.Default, sortProperty, true);
        }

        #endregion

        private static IEnumerable<TSource> SortWithShakerSort<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, bool descending)
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
            int indexCount = count + index;

            TSource[] sortMe = source.ToArray();

            for (var i = index; i < indexCount / 2; i++)
            {
                var swapFlag = false;

                for (var j = i; j < indexCount - i - 1 + index; j++)
                {
                    if (comparer.Compare(sortProperty(sortMe[j]), sortProperty(sortMe[j + 1])) == order)
                    {
                        Swap(ref sortMe[j], ref sortMe[j + 1]);
                        swapFlag = true;
                    }
                }

                for (var j = indexCount - 2 - i + index; j > i; j--)
                {
                    if (comparer.Compare(sortProperty(sortMe[j - 1]), sortProperty(sortMe[j])) == order)
                    {
                        Swap(ref sortMe[j - 1], ref sortMe[j]);
                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }

            return sortMe;
        }

        private static void Swap<TSource>(ref TSource source1, ref TSource source2)
        {
            var temp = source1;
            source1 = source2;
            source2 = temp;
        }

    }
}
