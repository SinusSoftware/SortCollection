using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace System
{
    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static class SortingAlgorithm
    {

        #region BubbleSort

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n^2)
        /// Best Case Time Complexity[Big - omega]: O(n)
        /// Average Time Complexity[Big - theta]: O(n^2)
        /// Space Complexity: O(1)
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSort<T>(this IEnumerable<T> source)
        {
            return SortWithBubbleSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the specified comparer.
        /// Worst Case Time Complexity[Big - O]: O(n^2)
        /// Best Case Time Complexity[Big - omega]: O(n)
        /// Average Time Complexity[Big - theta]: O(n^2)
        /// Space Complexity: O(1)
        /// Stable: Yes
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithBubbleSort(source, 0, source.Count(), comparer);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the specified comparer.
        /// Worst Case Time Complexity[Big - O]: O(n^2)
        /// Best Case Time Complexity[Big - omega]: O(n)
        /// Average Time Complexity[Big - theta]: O(n^2)
        /// Space Complexity: O(1)
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/>.
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
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

            var sortMe = source.ToArray();
            for (int i = 1; i < count + index; i++)
            {
                for (int j = index; j < (count + index - i); j++)
                {
                    if (comparer.Compare(sortMe[j], sortMe[j + 1]) == 1)
                    {
                        T temp = sortMe[j];
                        sortMe[j] = sortMe[j + 1];
                        sortMe[j + 1] = temp;
                    }
                }
            }
            return sortMe;
        }

        #endregion

        #region SelectionSort

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n^2)
        /// Best Case Time Complexity[Big - omega]: O(n^2)
        /// Average Time Complexity[Big - theta]: O(n^2)
        /// Space Complexity: O(1)
        /// Stable: No
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithSelectionSort<T>(this IEnumerable<T> source)
        {
            return SortWithSelectionSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n^2)
        /// Best Case Time Complexity[Big - omega]: O(n^2)
        /// Average Time Complexity[Big - theta]: O(n^2)
        /// Space Complexity: O(1)
        /// Stable: No
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithSelectionSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithSelectionSort(source, 0, source.Count(), comparer);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n^2)
        /// Best Case Time Complexity[Big - omega]: O(n^2)
        /// Average Time Complexity[Big - theta]: O(n^2)
        /// Space Complexity: O(1)
        /// Stable: No
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/>.
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithSelectionSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
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

            var sortMe = source.ToArray();
            for (int i = index; i < count + index - 1; i++)
            {
                var minValue = i;
                for (int j = i + 1; j < count + index; j++)
                {
                    if (comparer.Compare(sortMe[j], sortMe[minValue]) == -1)
                    {
                        minValue = j;
                    }
                }
                var tempVar = sortMe[minValue];
                sortMe[minValue] = sortMe[i];
                sortMe[i] = tempVar;
            }


            return sortMe;
        }

        #endregion

        #region InsertionSort

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n^2)
        /// Best Case Time Complexity[Big - omega]: O(n)
        /// Average Time Complexity[Big - theta]: O(n^2)
        /// Space Complexity: O(1)
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithInsertionSort<T>(this IEnumerable<T> source)
        {
            return SortWithInsertionSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n^2)
        /// Best Case Time Complexity[Big - omega]: O(n)
        /// Average Time Complexity[Big - theta]: O(n^2)
        /// Space Complexity: O(1)
        /// Stable: Yes
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithInsertionSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithInsertionSort(source, 0, source.Count(), comparer);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n^2)
        /// Best Case Time Complexity[Big - omega]: O(n)
        /// Average Time Complexity[Big - theta]: O(n^2)
        /// Space Complexity: O(1)
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/>.
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithInsertionSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
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

            var sortMe = source.ToArray();

            for (int i = index; i < count + index - 1; i++)
            {
                for (int j = i + 1; j > index; j--)
                {
                    if (comparer.Compare(sortMe[j - 1], sortMe[j]) == 1)
                    {
                        var temp = sortMe[j - 1];
                        sortMe[j - 1] = sortMe[j];
                        sortMe[j] = temp;
                    }
                }
            }

            return sortMe;
        }

        #endregion

        #region SlowSort

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// SlowSort is very, very slow. It is more a gag algorithmn. Don't use it!
        /// Stable: No
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithSlowSort<T>(this IEnumerable<T> source)
        {
            return SortWithSlowSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// SlowSort is very, very slow. It is more a gag algorithmn. Don't use it!
        /// Stable: No
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithSlowSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithSlowSort(source, 0, source.Count(), comparer);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// SlowSort is very, very slow. It is more a gag algorithmn. Don't use it!
        /// Stable: No
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/>.
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithSlowSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
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

            var sortMe = source.ToArray();

            Slowsort(sortMe, index, count + index -1, comparer);

            return sortMe;
        }

        private static void Slowsort<T>(T[] source, int i, int j, IComparer<T> comparer)
        {
            if (i >= j)
            {
                return;
            }
            int m = (i + j) / 2;
            Slowsort(source, i, m, comparer);
            Slowsort(source, m + 1, j, comparer);
            if(comparer.Compare(source[j], source[m]) < 0)
            {
                T hilfs = source[j];
                source[j] = source[m];
                source[m] = hilfs;
            }
            Slowsort(source, i, j - 1, comparer);
        }

        #endregion

        #region ShellSort

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Complexity: Dependent on GapSeqeuenz (Default: Sedgewick Year 1986)
        /// Stable: No
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShellSort<T>(this IEnumerable<T> source, GapSequences gapSequence = GapSequences.Sedgewick1986)
        {
            return SortWithShellSort(source, 0, source.Count(), Comparer<T>.Default, gapSequence);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the specified comparer.
        /// Complexity: Dependent on GapSeqeuenz (Default: Sedgewick Year 1986)
        /// Stable: No
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShellSort<T>(this IEnumerable<T> source, IComparer<T> comparer, GapSequences gapSequence = GapSequences.Sedgewick1986)
        {
            return SortWithShellSort(source, 0, source.Count(), comparer, gapSequence);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the specified comparer.
        /// Complexity: Dependent on GapSeqeuenz (Default: Sedgewick Year 1986)
        /// Stable: No
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/>.
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShellSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer, GapSequences gapSequence = GapSequences.Sedgewick1986)
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

            var sortMe = source.ToArray();

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
            T t;

            int n = count + index;
            for (k = 0; k < gaps.Length; k++)
            {
                h = gaps[k];
                for (i = h; i < n; i++)
                {
                    t = sortMe[i];
                    j = i;
                    while (j >= h + index && comparer.Compare(sortMe[j - h], t) == 1)
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


        #endregion

        #region HeapSort

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst case time O(nlg⁡n)O
        /// Best case time O(n)
        /// Average case time O(nlg⁡n)
        /// Space O(1)
        /// Stable: No
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithHeapSort<T>(this IEnumerable<T> source)
        {
            return SortWithHeapSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst case time O(nlg⁡n)O
        /// Best case time O(n)
        /// Average case time O(nlg⁡n)
        /// Space O(1)
        /// Stable: No
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithHeapSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithHeapSort(source, 0, source.Count(), comparer);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst case time O(nlg⁡n)O
        /// Best case time O(n)
        /// Average case time O(nlg⁡n)
        /// Space O(1)
        /// Stable: No
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/>.
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithHeapSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
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

            var sortMe = source.ToArray();
            int rangeLength = count + index;
            for (int i = count / 2; i >= 0; --i)
            {
                Heapify(sortMe, rangeLength, i, index, comparer);
            }
            for (int i = rangeLength - 1; i > index; --i)
            {
                var swap = sortMe[index];
                sortMe[index] = sortMe[i];
                sortMe[i] = swap;
                Heapify(sortMe, i, 0, index, comparer);
            }

            return sortMe;
        }

        private static void Heapify<T>(T[] list, int n, int i, int index, IComparer<T> comparer)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left + index < n && comparer.Compare(list[left + index], list[largest + index]) == 1)
                largest = left;
            if (right + index < n && comparer.Compare(list[right + index], list[largest + index]) == 1)
                largest = right;
            if (largest != i)
            {
                var swap = list[i + index];
                list[i + index] = list[largest + index];
                list[largest + index] = swap;
                Heapify(list, n, largest, index, comparer);
            }
        }

        #endregion

        #region MergeSort

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n* log n)
        /// Best Case Time Complexity[Big - omega]: O(n* log n)
        /// Average Time Complexity[Big - theta]: O(n* log n)
        /// Space Complexity: O(n)
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithMergeSort<T>(this IEnumerable<T> source)
        {
            return SortWithMergeSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n* log n)
        /// Best Case Time Complexity[Big - omega]: O(n* log n)
        /// Average Time Complexity[Big - theta]: O(n* log n)
        /// Space Complexity: O(n)
        /// Stable: Yes
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithMergeSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithMergeSort(source, 0, source.Count(), comparer);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// Worst Case Time Complexity[Big - O]: O(n* log n)
        /// Best Case Time Complexity[Big - omega]: O(n* log n)
        /// Average Time Complexity[Big - theta]: O(n* log n)
        /// Space Complexity: O(n)
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/>.
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithMergeSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
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

            var sortMe = source.ToArray();
            MergeSort(sortMe, index, count - 1 + index, comparer);
            return sortMe;
        }

        private static void MergeSort<T>(T[] input, int left, int right, IComparer<T> comparer)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;

                MergeSort(input, left, middle, comparer);
                MergeSort(input, middle + 1, right, comparer);

                Merge(input, left, middle, right, comparer);
            }
        }

        private static void Merge<T>(T[] input, int left, int middle, int right, IComparer<T> comparer)
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
                else if (comparer.Compare(leftArray[i], rightArray[j]) <= 0)
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

        #endregion

        #region CountingSort

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm is for positiv integers only
        /// Time complexity: O(N+K)
        /// Worst case: when data is skewed and range is large
        /// Best Case: When all elements are same
        /// Average Case: O(N+K) (N & K equally dominant)
        /// Space Complexity: O(K)
        /// where:
        /// N is the number of elements
        /// K is the range of elements(K = largest element - smallest element)
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<int> SortWithCountingSort(this IEnumerable<int> source)
        {
            return SortWithCountingSort(source, source => source);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm is for positiv integers only
        /// Time complexity: O(N+K)
        /// Worst case: when data is skewed and range is large
        /// Best Case: When all elements are same
        /// Average Case: O(N+K) (N & K equally dominant)
        /// Space Complexity: O(K)
        /// where:
        /// N is the number of elements
        /// K is the range of elements(K = largest element - smallest element)
        /// Stable: Yes
        /// </summary>
        /// <param name="sortProperty">The sorting property</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithCountingSort<T>(this IEnumerable<T> source, Func<T, int> sortProperty)
        {
            List<int> buckets = new();

            T[] sortMe = source.ToArray();
            for (int i = 0; i < sortMe.Length; i++)
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

            T[] result = new T[sortMe.Length];
            for (int i = 0; i < sortMe.Length; i++)
            {
                int theVal = sortProperty(sortMe[i]);
                int destIndex = startIndex[theVal]++;
                result[destIndex] = sortMe[i];
            }

            return result;
        }

        #endregion

        #region RadixSort     

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm is for positiv integers only
        /// Stable: Yes
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<uint> SortWithRadixSort(this IEnumerable<uint> source)
        {
            return SortWithRadixSort(source, source => source);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm is for positiv integers only
        /// Stable: Yes
        /// </summary>
        /// <param name="sortProperty">The sorting property</param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithRadixSort<T>(this IEnumerable<T> source, Func<T, uint> sortProperty)
        {
            T[] sortMe = source.ToArray();

            T[] helper = new T[sortMe.Length];

            // number of bits our group will be long 
            int r = 4; // try to set this also to 2, 8 or 16 to see if it is quicker or not 

            // number of bits of a C# int 
            int b = 32;

            int[] count = new int[1 << r];
            int[] prefix = new int[1 << r];

            // number of groups
            int groups = (int)Math.Ceiling(b / (double)r);

            // the mask to identify groups 
            int mask = (1 << r) - 1;

            // the algorithm: 
            for (int c = 0, shift = 0; c < groups; c++, shift += r)
            {
                // reset count array 
                for (int j = 0; j < count.Length; j++)
                    count[j] = 0;

                // counting elements of the c-th group 
                for (int i = 0; i < sortMe.Length; i++)
                {
                    uint value = sortProperty(sortMe[i]);
                    count[(value >> shift) & mask]++;
                }

                // calculating prefixes 
                prefix[0] = 0;
                for (int i = 1; i < count.Length; i++)
                    prefix[i] = prefix[i - 1] + count[i - 1];

                // from a[] to t[] elements ordered by c-th group 
                for (int i = 0; i < sortMe.Length; i++)
                {
                    uint value = sortProperty(sortMe[i]);
                    helper[prefix[(value >> shift) & mask]++] = sortMe[i];
                }

                // a[]=t[] and start again until the last group 
                helper.CopyTo(sortMe, 0);
            }
            return sortMe;
        }

        #endregion

        #region IntroSort 

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm use insertionsort, heapsort and quicksort
        /// Stable: No
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithIntroSort<T>(this IEnumerable<T> source)
        {
            return SortWithIntroSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm use insertionsort, heapsort and quicksort
        /// Stable: No
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]

        public static IEnumerable<T> SortWithIntroSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithIntroSort(source, 0, source.Count(), comparer);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// This algorithm use insertionsort, heapsort and quicksort
        /// Stable: No
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/>.
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithIntroSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
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


            int partitionSize = Partition(ref sortMe, index, count - 1, comparer);

            if (partitionSize < 16)
            {
                sortMe = SortWithInsertionSort(sortMe.ToList(), index, count, comparer).ToArray();
            }
            else if (partitionSize > (2 * Math.Log(sortMe.Length)))
            {
                sortMe = SortWithHeapSort(sortMe.ToList(), index, count, comparer).ToArray();
            }
            else
            {
                QuickSort(ref sortMe, index, count - 1, comparer);
            }

            return sortMe;
        }

        private static void QuickSort<T>(ref T[] input, int left, int right, IComparer<T> comparer)
        {
            if (left < right)
            {
                int q = Partition(ref input, left, right, comparer);
                QuickSort(ref input, left, q - 1, comparer);
                QuickSort(ref input, q + 1, right, comparer);
            }
        }

        private static int Partition<T>(ref T[] input, int left, int right, IComparer<T> comparer)
        {
            T pivot = input[right];
            T temp;
            int i = left;

            for (int j = left; j < right; ++j)
            {
                if (comparer.Compare(input[j], pivot) <= 0)
                {
                    temp = input[j];
                    input[j] = input[i];
                    input[i] = temp;
                    i++;
                }
            }

            input[right] = input[i];
            input[i] = pivot;

            return i;
        }

        #endregion

        #region TimSort

        public const int RUN = 32;

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<int> SortWithTimSort(this IEnumerable<int> source)
        {
            IEnumerable<int> arr = source.ToArray();
            //int[] arr23 = arr.ToArray();
            //int[] arr = source.ToArray();
            int n = source.Count();
            //IEnumerable<int> test = new List<int>();

            for (int i = 0; i < n; i += RUN)
            {
                arr = SortWithInsertionSort(arr, i, Math.Min(n - i, RUN), Comparer<int>.Default);
            }

            int[] arr2 = arr.ToArray();
            for (int size = RUN; size < n; size = 2 * size)
            {
                for (int left = 0; left < n; left += 2 * size)
                {

                    int mid = left + size - 1;
                    int right = Math.Min((left + 2 * size - 1), (n - 1));

                    if (mid < right)
                    {
                        Merge(arr2, left, mid, right, Comparer<int>.Default);
                    }
                }
            }


            return arr2;


        }

        #endregion
    }
}
