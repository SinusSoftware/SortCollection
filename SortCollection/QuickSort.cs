namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class QuickSort
    {
        #region Ascending

        /// <summary>
        /// 
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithQuickSort<T>(this IEnumerable<T> source)
        {
            return SortWithQuickSort(source, 0, source.Count(), Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithQuickSort<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithQuickSort(source, index, count, Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithQuickSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithQuickSort(source, 0, source.Count(), comparer, source => source, false);
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
        public static IEnumerable<T> SortWithQuickSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithQuickSort(source, index, count, comparer, source => source, false);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithQuickSortBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithQuickSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false);
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
        public static IEnumerable<TSource> SortWithQuickSortBy<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithQuickSort(source, index, count, Comparer<TKey>.Default, sortProperty, false);
        }

        #endregion

        #region Descending

        /// <summary>
        /// 
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithQuickSortDescending<T>(this IEnumerable<T> source)
        {
            return SortWithQuickSort(source, 0, source.Count(), Comparer<T>.Default, source => source, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithQuickSortDescending<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithQuickSort(source, index, count, Comparer<T>.Default, source => source, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithQuickSortDescending<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithQuickSort(source, 0, source.Count(), comparer, source => source, true);
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
        public static IEnumerable<T> SortWithQuickSortDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithQuickSort(source, index, count, comparer, source => source, true);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithQuickSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithQuickSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, true);
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
        public static IEnumerable<TSource> SortWithQuickSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithQuickSort(source, index, count, Comparer<TKey>.Default, sortProperty, true);
        }

        #endregion

        internal static IEnumerable<TSource> SortWithQuickSort<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, bool descending)
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

            int top = -1;
            int[] stack = new int[sortMe.Length];

            stack[++top] = startIndex;
            stack[++top] = endIndex;

            while (top >= 0)
            {
                endIndex = stack[top--];
                startIndex = stack[top--];

                int p = Partition(ref sortMe, startIndex, endIndex, comparer, sortProperty, order);

                if (p - 1 > startIndex)
                {
                    stack[++top] = startIndex;
                    stack[++top] = p - 1;
                }

                if (p + 1 < endIndex)
                {
                    stack[++top] = p + 1;
                    stack[++top] = endIndex;
                }
            }
            
            return sortMe;
        }

        internal static int Partition<TSource, TKey>(ref TSource[] data, int left, int right, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            TSource x = data[right];
            int i = left - 1;

            for (int j = left; j <= right - 1; ++j)
            {
                if(comparer.Compare(sortProperty(data[j]), sortProperty(x)) == order)
                {
                    ++i;
                    Swap(ref data[i], ref data[j]);
                }
            }

            Swap(ref data[i + 1], ref data[right]);

            return i + 1;
        }
       
        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}
