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
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// This algorithm is for positiv integers only<br/>
        /// Time complexity: O(n+k)<br/>
        /// Worst case: when data is skewed and range is large<br/>
        /// Best Case: When all elements are same<br/>
        /// Average Case: O(n+k) (n &amp; k equally dominant)<br/>
        /// Space Complexity: O(k)<br/>
        /// where:<br/>
        /// n is the number of elements<br/>
        /// k is the range of elements(k = largest element - smallest element)<br/>
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<int> SortWithCountingSort(this IEnumerable<int> source)
        {
            return SortWithCountingSort(source, 0, source.Count(), source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// This algorithm is for positiv integers only<br/>
        /// Time complexity: O(n+k)<br/>
        /// Worst case: when data is skewed and range is large<br/>
        /// Best Case: When all elements are same<br/>
        /// Average Case: O(n+k) (n &amp; k equally dominant)<br/>
        /// Space Complexity: O(k)<br/>
        /// where:<br/>
        /// n is the number of elements<br/>
        /// k is the range of elements(k = largest element - smallest element)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<int> SortWithCountingSort(this IEnumerable<int> source, int index, int count)
        {
            return SortWithCountingSort(source, index, count, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// This algorithm is for positiv integers only<br/>
        /// Time complexity: O(n+k)<br/>
        /// Worst case: when data is skewed and range is large<br/>
        /// Best Case: When all elements are same<br/>
        /// Average Case: O(n+k) (n &amp; k equally dominant)<br/>
        /// Space Complexity: O(k)<br/>
        /// where:<br/>
        /// n is the number of elements<br/>
        /// k is the range of elements(k = largest element - smallest element)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithCountingSortBy<T>(this IEnumerable<T> source, Func<T, int> sortProperty)
        {
            return SortWithCountingSort(source, 0, source.Count(), sortProperty, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// This algorithm is for positiv integers only<br/>
        /// Time complexity: O(n+k)<br/>
        /// Worst case: when data is skewed and range is large<br/>
        /// Best Case: When all elements are same<br/>
        /// Average Case: O(n+k) (n &amp; k equally dominant)<br/>
        /// Space Complexity: O(k)<br/>
        /// where:<br/>
        /// n is the number of elements<br/>
        /// k is the range of elements(k = largest element - smallest element)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithCountingSortBy<T>(this IEnumerable<T> source, int index, int count, Func<T, int> sortProperty)
        {
            return SortWithCountingSort(source, index, count, sortProperty, false);
        }

        #endregion

        #region Descending

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// This algorithm is for positiv integers only<br/>
        /// Time complexity: O(n+k)<br/>
        /// Worst case: when data is skewed and range is large<br/>
        /// Best Case: When all elements are same<br/>
        /// Average Case: O(n+k) (n &amp; k equally dominant)<br/>
        /// Space Complexity: O(k)<br/>
        /// where:<br/>
        /// n is the number of elements<br/>
        /// k is the range of elements(k = largest element - smallest element)<br/>
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<int> SortWithCountingSortDescending(this IEnumerable<int> source)
        {
            return SortWithCountingSort(source, 0, source.Count(), source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// This algorithm is for positiv integers only<br/>
        /// Time complexity: O(n+k)<br/>
        /// Worst case: when data is skewed and range is large<br/>
        /// Best Case: When all elements are same<br/>
        /// Average Case: O(n+k) (n &amp; k equally dominant)<br/>
        /// Space Complexity: O(k)<br/>
        /// where:<br/>
        /// n is the number of elements<br/>
        /// k is the range of elements(k = largest element - smallest element)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<int> SortWithCountingSortDescending(this IEnumerable<int> source, int index, int count)
        {
            return SortWithCountingSort(source, index, count, source => source, true);
        }

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// This algorithm is for positiv integers only<br/>
        /// Time complexity: O(n+k)<br/>
        /// Worst case: when data is skewed and range is large<br/>
        /// Best Case: When all elements are same<br/>
        /// Average Case: O(n+k) (n &amp; k equally dominant)<br/>
        /// Space Complexity: O(k)<br/>
        /// where:<br/>
        /// n is the number of elements<br/>
        /// k is the range of elements(k = largest element - smallest element)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithCountingSortByDescending<T>(this IEnumerable<T> source, Func<T, int> sortProperty)
        {
            return SortWithCountingSort(source, 0, source.Count(), sortProperty, true);
        }

        /// <summary>
        /// Sorts the elements descending in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// This algorithm is for positiv integers only<br/>
        /// Time complexity: O(n+k)<br/>
        /// Worst case: when data is skewed and range is large<br/>
        /// Best Case: When all elements are same<br/>
        /// Average Case: O(n+k) (n &amp; k equally dominant)<br/>
        /// Space Complexity: O(k)<br/>
        /// where:<br/>
        /// n is the number of elements<br/>
        /// k is the range of elements(k = largest element - smallest element)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithCountingSortByDescending<T>(this IEnumerable<T> source, int index, int count, Func<T, int> sortProperty)
        {
            return SortWithCountingSort(source, index, count, sortProperty, true);
        }

        #endregion

        private static IEnumerable<TSource> SortWithCountingSort<TSource>(this IEnumerable<TSource> source, int index, int count, Func<TSource, int> sortProperty, bool descending)
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
            for (int i = index; i < count + index; i++)
            {
                int value = sortProperty(sortMe[i]);

                for (int j = buckets.Count; j <= value; j++)
                    buckets.Add(0);

                buckets[value]++;
            }

            int[] startIndex = new int[buckets.Count];
            if (!descending)
            {
                for (int j = 1; j < startIndex.Length; j++)
                {
                    startIndex[j] = buckets[j - 1] + startIndex[j - 1];
                }
            }
            else
            {
                int total = 0;
                for (int j = buckets.Count - 1; j >= 0; j--)
                {
                    startIndex[j] = total;
                    total += buckets[j];
                }
            }

            TSource[] result = source.ToArray();
            for (int i = index; i < count + index; i++)
            {
                int sortValue = sortProperty(sortMe[i]);
                int destinationIndex = startIndex[sortValue]++;
                result[destinationIndex + index] = sortMe[i];
            }

            return result;
        }
    }
}
