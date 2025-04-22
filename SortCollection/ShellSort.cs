namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class ShellSort
    {
        #region Ascending

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Complexity: Dependent on GapSeqeuenz (Default: Sedgewick Year 1986)<br/>
        /// Stable: No
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShellSort<T>(this IEnumerable<T> source, GapSequences gapSequence = GapSequences.Sedgewick1986)
        {
            return SortWithShellSort(source, 0, source.Count(), Comparer<T>.Default, source => source, false, gapSequence);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithSlowSort<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithShellSort(source, index, count, Comparer<T>.Default, source => source, false);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Complexity: Dependent on GapSeqeuenz (Default: Sedgewick Year 1986)<br/>
        /// Stable: No
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShellSort<T>(this IEnumerable<T> source, IComparer<T> comparer, GapSequences gapSequence = GapSequences.Sedgewick1986)
        {
            return SortWithShellSort(source, 0, source.Count(), comparer, source => source, false, gapSequence);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Complexity: Dependent on GapSeqeuenz (Default: Sedgewick Year 1986)<br/>
        /// Stable: No
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
        public static IEnumerable<T> SortWithShellSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer, GapSequences gapSequence = GapSequences.Sedgewick1986)
        {
            return SortWithShellSort(source, index, count, comparer, source => source, false, gapSequence);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithShellSortBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithShellSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithShellSortBy<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithShellSort(source, index, count, Comparer<TKey>.Default, sortProperty, false);
        }

        #endregion

        #region Descending

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShellSortDescending<T>(this IEnumerable<T> source, GapSequences gapSequence = GapSequences.Sedgewick1986)
        {
            return SortWithShellSort(source, 0, source.Count(), Comparer<T>.Default, source => source, false, gapSequence);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithSlowSortDescending<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithShellSort(source, index, count, Comparer<T>.Default, source => source, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShellSortDescending<T>(this IEnumerable<T> source, IComparer<T> comparer, GapSequences gapSequence = GapSequences.Sedgewick1986)
        {
            return SortWithShellSort(source, 0, source.Count(), comparer, source => source, false, gapSequence);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShellSortDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer, GapSequences gapSequence = GapSequences.Sedgewick1986)
        {
            return SortWithShellSort(source, index, count, comparer, source => source, false, gapSequence);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithShellSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithShellSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithShellSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithShellSort(source, index, count, Comparer<TKey>.Default, sortProperty, false);
        }

        #endregion

        private static IEnumerable<TSource> SortWithShellSort<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, bool descending, GapSequences gapSequence = GapSequences.Sedgewick1986)
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

            int order = descending ? -1 : 1;
            TSource[] sortMe = source.ToArray();

            int[] gaps = gapSequence switch
            {
                GapSequences.Shell => shell,
                GapSequences.Hibbard => hibbard,
                GapSequences.PapernovStasevich => papernovStasevich,
                GapSequences.Pratt => pratt,
                GapSequences.Knuth => knuth,
                GapSequences.IncerpiSedgewick => incerpiSedgewick,
                GapSequences.Sedgewick1982 => sedgewick1982,
                GapSequences.Sedgewick1986 => sedgewick1986,
                GapSequences.Tokuda => tokuda,
                GapSequences.Ciura => ciura,
                _ => sedgewick1986,
            };

            int i, j, k, h;
            TSource t;

            int n = count + index;
            for (k = 0; k < gaps.Length; k++)
            {
                h = gaps[k];
                for (i = h; i < n; i++)
                {
                    t = sortMe[i];
                    j = i;
                    while (j >= h + index && comparer.Compare(sortProperty(sortMe[j - h]), sortProperty(t)) == order)
                    {
                        sortMe[j] = sortMe[j - h];
                        j -= h;
                    }
                    sortMe[j] = t;
                }
            }
            return sortMe;
        }

        public enum GapSequences
        {
            Shell,
            Hibbard,
            PapernovStasevich,
            Pratt,
            Knuth,
            IncerpiSedgewick,
            Sedgewick1982,
            Sedgewick1986,
            Tokuda,
            Ciura
        }

        private static readonly int[] shell = { 1073741824, 536870912, 268435453, 134217728, 67108864, 33554432, 16777216, 8388608, 4194304, 2097152, 1048576, 524288, 262144, 131072, 65536, 32768, 16384, 8192, 4096, 2048, 1024, 512, 256, 128, 64, 32, 16, 8, 4, 2, 1 };

        private static readonly int[] hibbard = { 2147483647, 1073741823, 536870911, 268435455, 134217727, 67108863, 33554431, 16777215, 8388607, 4194303, 2097151, 1048575, 524287, 262143, 131071, 65535, 32767, 19383, 8191, 4095, 2047, 1023, 255, 127, 63, 31, 15, 7, 3, 1 };

        private static readonly int[] papernovStasevich = { 1073741825, 536870913, 268435457, 134217729, 67108865, 33554433, 16777217, 8388609, 4194305, 2097153, 1048577, 524289, 262145, 131073, 65537, 32769, 16385, 8193, 4097, 2049, 1025, 513, 257, 129, 65, 33, 17, 9, 5, 3, 1 };

        private static readonly int[] pratt = { 3888, 3456, 3072, 2916, 2592, 2304, 2187, 2048, 1944, 1728, 1536, 1485, 1296, 1152, 1024, 972, 864, 768, 729, 648, 576, 512, 486, 432, 384, 324, 288, 256, 243, 216, 192, 162, 144, 128, 108, 96, 81, 72, 64, 54, 48, 32, 27, 24, 18, 16, 12, 9, 8, 6, 4, 3, 2, 1 };

        private static readonly int[] knuth = { 1743392200, 581130733, 193710244, 64570081, 21523360, 7174453, 2391484, 797161, 265720, 88573, 29524, 9841, 3280, 1093, 364, 121, 40, 13, 4, 1 };

        private static readonly int[] incerpiSedgewick = { 2085837936, 852913488, 343669872, 114556624, 49095696, 21479367, 8382192, 3402672, 1391376, 463792, 198768, 86961, 13776, 4592, 1968, 861, 336, 112, 48, 21, 7, 3, 1 };

        private static readonly int[] sedgewick1982 = { 1073790977, 268460033, 67121153, 16783361, 4197377, 1050113, 262913, 65921, 16577, 4193, 1073, 281, 77, 23, 8, 1 };

        private static readonly int[] sedgewick1986 = { 1073643521, 603906049, 268386305, 150958081, 67084289, 37730305, 16764929, 9427969, 4188161, 2354689, 1045505, 587521, 260609, 146305, 64769, 36289, 16001, 8929, 3905, 2161, 929, 505, 209, 109, 41, 19, 5, 1 };

        private static readonly int[] tokuda = { 1147718700, 510097200, 226709866, 100759940, 44782196, 19903198, 8845866, 3931496, 1747331, 776591, 345152, 153401, 68178, 30301, 13467, 5985, 2660, 1182, 525, 233, 103, 46, 20, 9, 4, 1 };

        private static readonly int[] ciura = { 1698453753, 754868335, 335497038, 149109795, 66271020, 29453787, 13090572, 5818032, 2585792, 1149241, 510774, 227011, 100894, 44842, 19930, 8858, 3937, 1750, 701, 301, 132, 57, 23, 10, 4, 1 };

    }
}
