namespace System
{
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    public static class SortingAlgorithm
    {

        #region BubbleSort

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the default comparer.
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSort<T>(this IEnumerable<T> source)
        {
            return SortWithBubbleSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <see cref="IEnumerable{T}"/>
        /// using the specified comparer.>
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
            for (int i = 1; i < count; i++)
            {
                for (int j = index; j < (count - i); j++)
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

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithSelectionSort<T>(this IEnumerable<T> source)
        {
            return SortWithSelectionSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithSelectionSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithSelectionSort(source, 0, source.Count(), comparer);
        }

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
            for (int i = index; i < count - 1; i++)
            {
                var minValue = i;
                for (int j = i + 1; j < count; j++)
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

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithInsertionSort<T>(this IEnumerable<T> source)
        {
            return SortWithInsertionSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithInsertionSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithInsertionSort(source, 0, source.Count(), comparer);
        }

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

            for (int i = index; i < count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
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

        #region HeapSort

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithHeapSort<T>(this IEnumerable<T> source)
        {
            return SortWithHeapSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithHeapSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithHeapSort(source, 0, source.Count(), comparer);
        }

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
            for (int i = count / 2 - 1; i >= index; i--)
            {
                Heapify(sortMe, count, i, comparer);
            }
            for (int i = count - 1; i >= index; i--)
            {
                var temp = sortMe[0];
                sortMe[0] = sortMe[i];
                sortMe[i] = temp;
                Heapify(sortMe, i, 0, comparer);
            }

            return sortMe;
        }

        private static void Heapify<T>(T[] list, int n, int i, IComparer<T> comparer)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && comparer.Compare(list[left], list[largest]) == 1)
                largest = left;
            if (right < n && comparer.Compare(list[right], list[largest]) == 1)
                largest = right;
            if (largest != i)
            {
                var swap = list[i];
                list[i] = list[largest];
                list[largest] = swap;
                Heapify(list, n, largest, comparer);
            }
        }

        #endregion

       
        #region MergeSort

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithMergeSort<T>(this IEnumerable<T> source)
        {
            return SortWithMergeSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithMergeSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithMergeSort(source, 0, source.Count(), comparer);
        }

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

            if (source.Count() - index < count) //achtung, ein weniger zählen!!!
            {
                throw new ArgumentException("");
            }

            comparer ??= Comparer<T>.Default;

            var sortMe = source.ToArray();
            MergeSort(sortMe, index, count - 1, comparer);

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

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<int> SortWithCountingSort(this IEnumerable<int> source)
        {
            return SortWithCountingSort(source, source => source);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithCountingSort<T>(this IEnumerable<T> source, Func<T, int> sortProp)
        {
            List<int> buckets = new();

            T[] sortMe = source.ToArray();
            for (int i = 0; i < sortMe.Length; i++)
            {
                int value = sortProp(sortMe[i]);

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
                int theVal = sortProp(sortMe[i]);
                int destIndex = startIndex[theVal]++;
                result[destIndex] = sortMe[i];
            }

            return result;
        }

        #endregion


    }
}
