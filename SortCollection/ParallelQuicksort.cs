namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class ParallelQuicksort
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static void SortParallel<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length <= 1)
                return;

            
            //ParallelQuickSort(array, 0, array.Length - 1, 0);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithParallelQuicksort<T>(this IEnumerable<T> source)
        {

            return SortWithQuickSortTest(source, 0, source.Count(), Comparer<T>.Default, source => source, false);
           
        }

        private static IEnumerable<TSource> SortWithQuickSortTest<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, bool descending)
        {
            comparer ??= Comparer<TKey>.Default;
            int order = descending ? 1 : -1;
            TSource[] sortMe = source.ToArray();


            int startIndex = index;
            int endIndex = index + count - 1;

            ParallelQuickSort(sortMe, startIndex, endIndex, 0, comparer, sortProperty, order);

            return sortMe;
            //return source;
        }

        private static void ParallelQuickSort<TSource, TKey>(TSource[] array, int startIndex, int endIndex, int depth, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            //int depth = 1000;

            if (startIndex >= endIndex)
                return;

        

            //int pivotIndex = Partition(array, left, right);
            int pivotIndex = Partition(ref array, startIndex, endIndex, comparer, sortProperty, order);

            // Begrenze die Rekursionstiefe, um Thread-Overhead zu vermeiden
            if (depth < Environment.ProcessorCount)
            {
                Parallel.Invoke(
                    () => ParallelQuickSort(array, startIndex, pivotIndex - 1, depth + 1, comparer, sortProperty, order),
                    () => ParallelQuickSort(array, pivotIndex + 1, endIndex, depth + 1, comparer, sortProperty, order)
                );
            }
            else
            {
                QuickSortSequential(array, startIndex, pivotIndex - 1, depth, comparer, sortProperty, order);
                QuickSortSequential(array, pivotIndex + 1, endIndex, depth, comparer, sortProperty, order);
            }
        }

        private static int Partition<TSource, TKey>(ref TSource[] data, int left, int right, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            TSource x = data[right];
            int i = left - 1;

            for (int j = left; j <= right - 1; ++j)
            {
                if (comparer.Compare(sortProperty(data[j]), sortProperty(x)) == order)
                {
                    ++i;
                    Swap(ref data[i], ref data[j]);
                }
            }

            Swap(ref data[i + 1], ref data[right]);

            return i + 1;
        }

        private static void QuickSortSequential<TSource, TKey>(TSource[] array, int startIndex, int endIndex, int depth, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            if (startIndex >= endIndex)
                return;

            int pivotIndex = Partition(ref array, startIndex, endIndex, comparer, sortProperty, order);
            QuickSortSequential(array, startIndex, pivotIndex - 1, depth, comparer, sortProperty, order);
            QuickSortSequential(array, pivotIndex + 1, endIndex, depth, comparer, sortProperty, order);
        }

        private static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        /*
        private static void ParallelQuickSort<T>(T[] array, int left, int right, int depth) where T : IComparable<T>
        {
            if (left >= right)
                return;

            int pivotIndex = Partition(array, left, right);

            // Begrenze die Rekursionstiefe, um Thread-Overhead zu vermeiden
            if (depth < Environment.ProcessorCount)
            {
                Parallel.Invoke(
                    () => ParallelQuickSort(array, left, pivotIndex - 1, depth + 1),
                    () => ParallelQuickSort(array, pivotIndex + 1, right, depth + 1)
                );
            }
            else
            {
                QuickSortSequential(array, left, pivotIndex - 1);
                QuickSortSequential(array, pivotIndex + 1, right);
            }
        }

        private static int Partition<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            T pivot = array[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (array[j].CompareTo(pivot) <= 0)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);
            return i + 1;
        }

        private static void QuickSortSequential<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            if (left >= right)
                return;

            int pivotIndex = Partition(array, left, right);
            QuickSortSequential(array, left, pivotIndex - 1);
            QuickSortSequential(array, pivotIndex + 1, right);
        }

        private static void Swap<T>(T[] array, int a, int b)
        {
            (array[a], array[b]) = (array[b], array[a]);
        }
        */
    }
}

