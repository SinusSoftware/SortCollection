namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class CountingSort
    {

        #region Ascending

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm is for positiv integers only
        /// Time complexity: O(n+k)
        /// Worst case: when data is skewed and range is large
        /// Best Case: When all elements are same
        /// Average Case: O(n+k) (n &amp; k equally dominant)
        /// Space Complexity: O(k)
        /// where:
        /// n is the number of elements
        /// k is the range of elements(k = largest element - smallest element)
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<int> SortWithCountingSort(this IEnumerable<int> source)
        {
            return SortWithCountingSort(source, 0, source.Count(), source => source);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm is for positiv integers only
        /// Time complexity: O(n+k)
        /// Worst case: when data is skewed and range is large
        /// Best Case: When all elements are same
        /// Average Case: O(n+k) (n &amp; k equally dominant)
        /// Space Complexity: O(k)
        /// where:
        /// n is the number of elements
        /// k is the range of elements(k = largest element - smallest element)
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithCountingSort<T>(this IEnumerable<T> source, Func<T, int> sortProperty)
        {
            return SortWithCountingSort(source, 0, source.Count(), sortProperty);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm is for positiv integers only
        /// Time complexity: O(n+k)
        /// Worst case: when data is skewed and range is large
        /// Best Case: When all elements are same
        /// Average Case: O(n+k) (n &amp; k equally dominant)
        /// Space Complexity: O(k)
        /// where:
        /// n is the number of elements
        /// k is the range of elements(k = largest element - smallest element)
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<int> SortWithCountingSort(this IEnumerable<int> source, int index, int count)
        {
            return SortWithCountingSort(source, index, count, source => source);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm is for positiv integers only
        /// Time complexity: O(n+k)
        /// Worst case: when data is skewed and range is large
        /// Best Case: When all elements are same
        /// Average Case: O(n+k) (n &amp; k equally dominant)
        /// Space Complexity: O(k)
        /// where:
        /// n is the number of elements
        /// k is the range of elements(k = largest element - smallest element)
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/>
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithCountingSortBy<T>(this IEnumerable<T> source, int index, int count, Func<T, int> sortProperty)
        {
            return SortWithCountingSort(source, index, count, sortProperty);
        }

        #endregion

        //TODO:
        #region Descending

        #endregion

        private static IEnumerable<TSource> SortWithCountingSort<TSource>(this IEnumerable<TSource> source, int index, int count, Func<TSource, int> sortProperty)
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

            List<int> buckets = new();

            TSource[] sortMe = source.ToArray();
            for (int i = 0 + index; i < count + index; i++)
            {
                int value = sortProperty(sortMe[i]);
            
                for (int j = buckets.Count; j <= value; j++)
                    buckets.Add(0);

                buckets[value]++;
            }

            int[] startIndex = new int[buckets.Count];
            for (int j = 1; j < startIndex.Length; j++)
            {
                startIndex[j] = buckets[j - 1] + startIndex[j - 1];
            }

            TSource[] result = source.ToArray();
            for (int i = 0 + index; i < count + index; i++)
            {
                int sortValue = sortProperty(sortMe[i]);
                int destinationIndex = startIndex[sortValue]++;
                result[destinationIndex + index] = sortMe[i];
            }

            return result;
        }

    }
}
