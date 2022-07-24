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

        #region ShellSort

        public enum GapSequences
        {
            Shell,
            FrankLazarus,
            Hibbard,
            PapernovStasevich,
            Pratt,
            Knuth,
            IncerpiSedgewick,
            Sedgewick1982,
            Sedgewick1986,
            GonnetBaeza_Yates,
            Tokuda,
            Ciura
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShellSort<T>(this IEnumerable<T> source, GapSequences gapSequence = GapSequences.Shell)
        {
            return SortWithShellSort(source, 0, source.Count(), Comparer<T>.Default, gapSequence);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShellSort<T>(this IEnumerable<T> source, IComparer<T> comparer, GapSequences gapSequence = GapSequences.Shell)
        {
            return SortWithShellSort(source, 0, source.Count(), comparer, gapSequence);
        }

        private static readonly int[] testGaps = {2147483647, 1131376761, 410151271, 157840433,
                                     58548857, 21521774, 8810089, 3501671, 1355339, 543749, 213331,
                                     84801, 27901, 11969, 4711, 1968, 815, 271, 111, 41, 13, 4, 1};

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShellSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer, GapSequences gapSequence = GapSequences.Shell)
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
                GapSequences.Shell => testGaps,
                GapSequences.FrankLazarus => testGaps,
                GapSequences.Hibbard => testGaps,
                GapSequences.PapernovStasevich => testGaps,
                GapSequences.Pratt => testGaps,
                GapSequences.Knuth => testGaps,
                GapSequences.IncerpiSedgewick => testGaps,
                GapSequences.Sedgewick1982 => testGaps,
                GapSequences.Sedgewick1986 => testGaps,
                GapSequences.GonnetBaeza_Yates => testGaps,
                GapSequences.Tokuda => testGaps,
                GapSequences.Ciura => testGaps,
                _ => testGaps,
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
                throw new ArgumentOutOfRangeException("");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("");
            }

            if (source.Count() - index < count - 1)
            {
                throw new ArgumentException("");
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
        /// </summary>
        /// <param name="sortProperty">The sorting property.</param>
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

    }
}
