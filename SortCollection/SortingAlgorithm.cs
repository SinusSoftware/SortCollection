namespace System
{
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    public static class SortingAlgorithm
    {

        #region BubbleSort

        /// <summary>
        /// Sorts the elements in a range of elements in <c>System.Collections.Generic.IEnumerable</c>
        /// using the specified comparer.
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSort<T>(this IEnumerable<T> source)
        {
            return SortWithBubbleSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in <c>System.Collections.Generic.List</c>
        /// using the specified comparer.
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithBubbleSort(source, 0, source.Count(), comparer);
        }

        /// <summary>
        /// Sorts the elements in a range of elements in System.Collections.Generic.List`1
        /// using the specified comparer.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer`1 implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer`1.Default.
        /// </param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"> index is less than 0. -or- count is less than 0.</exception>
        /// <exception cref="ArgumentException">
        ///  index and count do not specify a valid range in the System.Collections.Generic.List`1.
        ///  -or- The implementation of comparer caused an error during the sort. For example,
        ///  comparer might not return 0 when comparing an item with itself.
        /// </exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("");
            }

            if (source.Count() - index < count)
            {
                throw new ArgumentException("");
            }

            comparer ??= Comparer<T>.Default;

            var list = source.ToList();
            for (int i = 1; i < count; i++)
            {
                for (int j = index; j < (count - i); j++)
                {
                    if (comparer.Compare(list[j], list[j + 1]) == 1)
                    {
                        T temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }
            return list;
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
                throw new ArgumentOutOfRangeException("");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("");
            }

            if (source.Count() - index < count)
            {
                throw new ArgumentException("");
            }

            comparer ??= Comparer<T>.Default;

            var list = source.ToList();
            for (int i = index; i < count - 1; i++)
            {
                var minValue = i;
                for (int j = i + 1; j < count; j++)
                {
                    if (comparer.Compare(list[j], list[minValue]) == -1)
                    {
                        minValue = j;
                    }
                }
                var tempVar = list[minValue];
                list[minValue] = list[i];
                list[i] = tempVar;
            }


            return list;
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
                throw new ArgumentOutOfRangeException("");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("");
            }

            if (source.Count() - index < count)
            {
                throw new ArgumentException("");
            }

            comparer ??= Comparer<T>.Default;

            var list = source.ToList();

            for (int i = index; i < count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (comparer.Compare(list[j - 1], list[j]) == 1)
                    {
                        var temp = list[j - 1];
                        list[j - 1] = list[j];
                        list[j] = temp;
                    }
                }
            }

            return list;
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
                throw new ArgumentOutOfRangeException("");
            }

            if (count < 0)
            {
                throw new ArgumentOutOfRangeException("");
            }

            if (source.Count() - index < count)
            {
                throw new ArgumentException("");
            }

            comparer ??= Comparer<T>.Default;

            var list = source.ToList();
            for (int i = count / 2 - 1; i >= index; i--)
                Heapify(list, count, i, comparer);
            for (int i = count - 1; i >= index; i--)
            {
                var temp = list[0];
                list[0] = list[i];
                list[i] = temp;
                Heapify(list, i, 0, comparer);
            }

            return list;
        }

        private static void Heapify<T>(List<T> list, int n, int i, IComparer<T> comparer)
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

            var test = source.ToArray();

            MergeSort(test, index, count - 1, comparer);

            return test;
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


        //public static void Mergesort(int[] a, int l, int r)
        //{
        //    int i, j, k, m;
        //    if (r > l)
        //    {
        //        m = (r + 1) / 2;
        //        Mergesort(a, l, m);
        //        Mergesort(a, m+1, r);
        //        for(i=m+1; i>l; i--)
        //        {
        //            b[i-1] =  
        //        }
        //    }
        //}

        //public static int[] SortArray(int[] array, int left, int right)
        //{
        //    if (left < right)
        //    {
        //        int middle = left + (right - left) / 2;

        //        SortArray(array, left, middle);
        //        SortArray(array, middle + 1, right);

        //        MergeArray(array, left, middle, right);
        //    }

        //    return array;
        //}


        //public static void MergeArray(int[] array, int left, int middle, int right)
        //{
        //    var leftArrayLength = middle - left + 1;
        //    var rightArrayLength = right - middle;
        //    var leftTempArray = new int[leftArrayLength];
        //    var rightTempArray = new int[rightArrayLength];
        //    int i, j;

        //    for (i = 0; i < leftArrayLength; ++i)
        //        leftTempArray[i] = array[left + i];
        //    for (j = 0; j < rightArrayLength; ++j)
        //        rightTempArray[j] = array[middle + 1 + j];

        //    i = 0;
        //    j = 0;
        //    int k = left;

        //    while (i < leftArrayLength && j < rightArrayLength)
        //    {
        //        if (leftTempArray[i] <= rightTempArray[j])
        //        {
        //            array[k++] = leftTempArray[i++];
        //        }
        //        else
        //        {
        //            array[k++] = rightTempArray[j++];
        //        }
        //    }

        //    while (i < leftArrayLength)
        //    {
        //        array[k++] = leftTempArray[i++];
        //    }

        //    while (j < rightArrayLength)
        //    {
        //        array[k++] = rightTempArray[j++];
        //    }
        //}



        #endregion

        #region CountingSort

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<int> SortWithCountingSort(this IEnumerable<int> source)
        {
            return SortWithCountingSort(source, source => source);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithCountingSort<T>(this IEnumerable<T> sortMe, Func<T, int> sortProp)
        {
            List<int> buckets = new();

            T[] test = sortMe.ToArray();
            for (int i = 0; i < test.Length; i++)
            {
                int theVal = sortProp(test[i]);

                for (int j = buckets.Count; j <= theVal; j++)
                    buckets.Add(0);

                buckets[theVal]++;
            }

            int[] startIndex = new int[buckets.Count];
            for (int j = 1; j < startIndex.Length; j++)
            {
                startIndex[j] = buckets[j - 1] + startIndex[j - 1];
            }

            T[] result = new T[test.Length];
            for (int i = 0; i < test.Length; i++)
            {
                int theVal = sortProp(test[i]);
                int destIndex = startIndex[theVal]++;
                result[destIndex] = test[i];
            }

            return result;
        }

        #endregion


    }
}
