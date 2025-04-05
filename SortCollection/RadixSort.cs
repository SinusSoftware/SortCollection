namespace System
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class RadixSort
    {
        #region Ascending     

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm is for positiv integers only
        /// Worst case: O(n2)
        /// Best Case: O(A(n+b)) If b equals O(n), the time complexity is O(a*n)
        /// Average Case: O(p*(n+d))
        /// Space Complexity: O(n+k)
        /// where:
        /// n is the number of elements
        /// k is the range of elements(k = largest element - smallest element)
        /// There are 'p' passes, and each digit can have up to 'd' different values
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<uint> SortWithRadixSort(this IEnumerable<uint> source, GroupBitLength groupLength = GroupBitLength.FourBits)
        {
            return SortWithRadixsort(source, 0, source.Count(), source => source, groupLength);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm is for positiv integers only
        /// Worst case: O(n2)
        /// Best Case: O(A(n+b)) If b equals O(n), the time complexity is O(a*n)
        /// Average Case: O(p*(n+d))
        /// Space Complexity: O(n+k)
        /// where:
        /// n is the number of elements
        /// k is the range of elements(k = largest element - smallest element)
        /// There are 'p' passes, and each digit can have up to 'd' different values
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithRadixSort<T>(this IEnumerable<T> source, Func<T, uint> sortProperty, GroupBitLength groupLength = GroupBitLength.FourBits)
        {
            return SortWithRadixsort(source, 0, source.Count(), sortProperty, groupLength);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm is for positiv integers only
        /// Worst case: O(n2)
        /// Best Case: O(A(n+b)) If b equals O(n), the time complexity is O(a*n)
        /// Average Case: O(p*(n+d))
        /// Space Complexity: O(n+k)
        /// where:
        /// n is the number of elements
        /// k is the range of elements(k = largest element - smallest element)
        /// There are 'p' passes, and each digit can have up to 'd' different values
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<uint> SortWithRadixSort(this IEnumerable<uint> source, int index, int count, GroupBitLength groupLength = GroupBitLength.FourBits)
        {
            return SortWithRadixsort(source, index, count, source => source, groupLength);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm is for positiv integers only
        /// Worst case: O(n2)
        /// Best Case: O(A(n+b)) If b equals O(n), the time complexity is O(a*n)
        /// Average Case: O(p*(n+d))
        /// Space Complexity: O(n+k)
        /// where:
        /// n is the number of elements
        /// k is the range of elements(k = largest element - smallest element)
        /// There are 'p' passes, and each digit can have up to 'd' different values
        /// Stable: Yes
        /// </summary>
        /// <param name="sortProperty">The sorting property</param>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/>
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithRadixSortBy<T>(this IEnumerable<T> source, int index, int count, Func<T, uint> sortProperty, GroupBitLength groupLength = GroupBitLength.FourBits)
        {
            return SortWithRadixsort(source, index, count, sortProperty, groupLength);
        }
        #endregion

        //TODO:
        #region Descending

        #endregion

        private static IEnumerable<T> SortWithRadixsort<T>(this IEnumerable<T> source, int index, int count, Func<T, uint> sortProperty, GroupBitLength groupLength = GroupBitLength.FourBits)
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

            T[] sortMe = source.ToArray();
            T[] helper = source.ToArray();

            int groupLengthInBit = (int)groupLength;
            int numberOfIntegerBits = 32;

            int[] countBitWise = new int[1 << groupLengthInBit];
            int[] prefix = new int[1 << groupLengthInBit];

            int groupsNumber = (int)Math.Ceiling(numberOfIntegerBits / (double)groupLengthInBit);
            int mask = (1 << groupLengthInBit) - 1;

            for (int c = 0, shift = 0; c < groupsNumber; c++, shift += groupLengthInBit)
            {
                for (int j = 0; j < countBitWise.Length; j++)
                    countBitWise[j] = 0;

                for (int i = 0 + index; i < count + index; i++)
                {
                    uint value = sortProperty(sortMe[i]);
                    countBitWise[(value >> shift) & mask]++;
                }

                prefix[0] = 0;
                for (int i = 1; i < countBitWise.Length; i++)
                    prefix[i] = prefix[i - 1] + countBitWise[i - 1];

                for (int i = index; i < count + index; i++)
                {
                    uint value = sortProperty(sortMe[i]);
                    helper[prefix[(value >> shift) & mask]++ + index] = sortMe[i];
                }

                helper.CopyTo(sortMe, 0);
            }
            return sortMe;
        }

        public enum GroupBitLength
        {
            [Description("Group will be 2 Bits long")]
            TwoBits = 2,
            [Description("Group will be 4 Bits long")]
            FourBits = 4,
            [Description("Group will be 8 Bits long")]
            EightBits = 8,
            [Description("Group will be 16 Bits long")]
            SixteenBits = 16
        }

    }
}
