namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;


    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class ParallelMergeSort
    {

        #region Ascending

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithParallelMergeSort<TSource>(this IEnumerable<TSource> source)
        {
            return SortWithParallelMergeSort(source, 0, source.Count(), Comparer<TSource>.Default, source => source, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelMergeSort<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithParallelMergeSort(source, index, count, Comparer<T>.Default, source => source, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelMergeSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithParallelMergeSort(source, 0, source.Count(), comparer, source => source, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelMergeSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithParallelMergeSort(source, index, count, comparer, source => source, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithParallelMergeSortBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithParallelMergeSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithParallelMergeSortBy<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithParallelMergeSort(source, index, count, Comparer<TKey>.Default, sortProperty, false);
        }

        #endregion

        #region Descending

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelMergeSortDescending<T>(this IEnumerable<T> source)
        {
            return SortWithParallelMergeSort(source, 0, source.Count(), Comparer<T>.Default, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelMergeSortDescending<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithParallelMergeSort(source, index, count, Comparer<T>.Default, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelMergeSortDescending<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithParallelMergeSort(source, 0, source.Count(), comparer, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelMergeSortDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithParallelMergeSort(source, index, count, comparer, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithParallelMergeSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithParallelMergeSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithParallelMergeSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithParallelMergeSort(source, index, count, Comparer<TKey>.Default, sortProperty, true);
        }

        #endregion

        private static IEnumerable<TSource> SortWithParallelMergeSort<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, bool descending)
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
            int order = descending ? 1 : -1;

            TSource[] temp = new TSource[source.Count()];
            TSource[] sortMe = source.ToArray();
            MergeSortParallel(sortMe, temp, index, count - 1 + index, 0, comparer, sortProperty, order);
            return sortMe;
        }

        private static void MergeSortParallel<TSource, TKey>(TSource[] array, TSource[] temp, int left, int right, int depth, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;

            // Abhängig von der Tiefe entscheiden, ob parallel oder sequentiell
            if (depth < Environment.ProcessorCount)
            {
                Parallel.Invoke(
                    () => MergeSortParallel(array, temp, left, middle, depth + 1, comparer, sortProperty, order),
                    () => MergeSortParallel(array, temp, middle + 1, right, depth + 1, comparer, sortProperty, order)
                );
            }
            else
            {
                MergeSortSequential(array, temp, left, middle, comparer, sortProperty, order);
                MergeSortSequential(array, temp, middle + 1, right, comparer, sortProperty, order);
            }

            Merge(array, temp, left, middle, right, comparer, sortProperty, order);
        }

        private static void MergeSortSequential<TSource, TKey>(TSource[] array, TSource[] temp, int left, int right, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;
            MergeSortSequential(array, temp, left, middle, comparer, sortProperty, order);
            MergeSortSequential(array, temp, middle + 1, right, comparer, sortProperty, order);
            Merge(array, temp, left, middle, right, comparer, sortProperty, order);
        }

        private static void Merge<TSource, TKey>(TSource[] array, TSource[] temp, int left, int middle, int right, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            int i = left;
            int j = middle + 1;
            int k = left;

            while (i <= middle && j <= right)
            {
                //if (array[i].CompareTo(array[j]) <= 0)
                if (comparer.Compare(sortProperty(array[i]), sortProperty(array[j])) <= order)
       
                    temp[k++] = array[i++];
                else
                    temp[k++] = array[j++];
            }

            while (i <= middle)
                temp[k++] = array[i++];

            while (j <= right)
                temp[k++] = array[j++];

            for (int t = left; t <= right; t++)
                array[t] = temp[t];
        }


        /*
        public static void SortTest<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length <= 1)
                return;

            T[] temp = new T[array.Length];
            MergeSortParallel(array, temp, 0, array.Length - 1, 0);
        }
        */

        /*
        private static void MergeSortParallel<TSource, TKey>(TSource[] input, TSource[] temp, int left, int right, int depth, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)

        //private static void MergeSortParallel<T>(T[] array, T[] temp, int left, int right, int depth) where T : IComparable<T>
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;

            // Abhängig von der Tiefe entscheiden, ob parallel oder sequentiell
            if (depth < Environment.ProcessorCount)
            {
                Parallel.Invoke(
                    () => MergeSortParallel(input, temp, left, middle, depth + 1, comparer, sortProperty, order),
                    () => MergeSortParallel(input, temp, middle + 1, right, depth + 1, comparer, sortProperty, order)
                );
            }
            else
            {
                MergeSortSequential(input, temp, left, middle, depth, comparer, sortProperty, order);
                MergeSortSequential(input, temp, middle + 1, right, depth, comparer, sortProperty, order);
            }

            Merge(input, temp, left, right, depth, comparer, sortProperty, order);
        }

        private static void MergeSortSequential<TSource, TKey>(TSource[] input, TSource[] temp, int left, int right, int depth, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;
            MergeSortSequential(input, temp, left, middle, depth, comparer, sortProperty, order);
            MergeSortSequential(input, temp, middle + 1, right, depth, comparer, sortProperty, order);
            Merge(input, temp, left, middle, right, comparer, sortProperty, order);
        }

        private static void Merge<TSource, TKey>(TSource[] array, TSource[] temp, int left, int middle, int right, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            int i = left;
            int j = middle + 1;
            int k = left;

            while (i <= middle && j <= right)
            {
                //if (array[i].CompareTo(array[j]) <= 0)
                if (comparer.Compare(sortProperty(array[i]), sortProperty(array[j])) == order || comparer.Compare(sortProperty(array[i]), sortProperty(array[j])) == 0)
                            temp[k++] = array[i++];
                else
                    temp[k++] = array[j++];
            }

            while (i <= middle)
                temp[k++] = array[i++];

            while (j <= right)
                temp[k++] = array[j++];

            for (int t = left; t <= right; t++)
                array[t] = temp[t];
        }
        */

        /*
        private static void MergeSortParallel<T>(T[] array, T[] temp, int left, int right, int depth) where T : IComparable<T>
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;

            // Abhängig von der Tiefe entscheiden, ob parallel oder sequentiell
            if (depth < Environment.ProcessorCount)
            {
                Parallel.Invoke(
                    () => MergeSortParallel(array, temp, left, middle, depth + 1),
                    () => MergeSortParallel(array, temp, middle + 1, right, depth + 1)
                );
            }
            else
            {
                MergeSortSequential(array, temp, left, middle);
                MergeSortSequential(array, temp, middle + 1, right);
            }

            Merge(array, temp, left, middle, right);
        }

        private static void MergeSortSequential<T>(T[] array, T[] temp, int left, int right) where T : IComparable<T>
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;
            MergeSortSequential(array, temp, left, middle);
            MergeSortSequential(array, temp, middle + 1, right);
            Merge(array, temp, left, middle, right);
        }

        private static void Merge<T>(T[] array, T[] temp, int left, int middle, int right) where T : IComparable<T>
        {
            int i = left;
            int j = middle + 1;
            int k = left;

            while (i <= middle && j <= right)
            {
                if (array[i].CompareTo(array[j]) <= 0)
                    temp[k++] = array[i++];
                else
                    temp[k++] = array[j++];
            }

            while (i <= middle)
                temp[k++] = array[i++];

            while (j <= right)
                temp[k++] = array[j++];

            for (int t = left; t <= right; t++)
                array[t] = temp[t];
        }

         */
    }
}
