namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class ParallelMergeSortAsync
    {

        /// <summary>
        ///Async Test
        /// </summary>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<TSource>>SortWithParallelMergeSortAsync<TSource>(this IEnumerable<TSource> source)
        {
            return await SortWithParallelMergeSortAsync(source, 0, source.Count(), Comparer<TSource>.Default, source => source, false);
        }

        private static async ValueTask<IEnumerable<TSource>> SortWithParallelMergeSortAsync<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey>? comparer, Func<TSource, TKey> sortProperty, bool descending)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException(nameof(index), index, "The index can't be less than 0.");

            if (count < 0)
                throw new ArgumentOutOfRangeException(nameof(count), count, "The count can't be less than 0.");

            if (source.Count() - index < count)
                throw new ArgumentException("Count must be greater than number of elements in source minus index");

            comparer ??= Comparer<TKey>.Default;
            int order = descending ? 1 : -1;

            var array = source.ToArray();
            var temp = new TSource[array.Length];

            await MergeSortParallelAsync(array, temp, index, count - 1 + index, 0, Environment.ProcessorCount, comparer, sortProperty, order)
                                        .ConfigureAwait(false);

            return array;
        }

        private static async ValueTask MergeSortParallelAsync<TSource, TKey>(TSource[] array, TSource[] temp, int left, int right, int depth, int maxDepth, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;

            if (depth < maxDepth)
            {
                await Task.WhenAll(
                    MergeSortParallelAsync(array, temp, left, middle, depth + 1, maxDepth, comparer, sortProperty, order).AsTask(),
                    MergeSortParallelAsync(array, temp, middle + 1, right, depth + 1, maxDepth, comparer, sortProperty, order).AsTask()
                ).ConfigureAwait(false);
            }
            else
            {
                await MergeSortSequentialAsync(array, temp, left, middle, comparer, sortProperty, order);
                await MergeSortSequentialAsync(array, temp, middle + 1, right, comparer, sortProperty, order);
            }

            Merge(array, temp, left, middle, right, comparer, sortProperty, order);
        }

        private static async ValueTask MergeSortSequentialAsync<TSource, TKey>(TSource[] array, TSource[] temp, int left, int right, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            if (left >= right)
                return;

            int middle = (left + right) / 2;
            await MergeSortSequentialAsync(array, temp, left, middle, comparer, sortProperty, order);
            await MergeSortSequentialAsync(array, temp, middle + 1, right, comparer, sortProperty, order);
            Merge(array, temp, left, middle, right, comparer, sortProperty, order);
        }

        private static void Merge<TSource, TKey>(TSource[] array, TSource[] temp, int left, int middle, int right, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order)
        {
            int i = left;
            int j = middle + 1;
            int k = left;

            while (i <= middle && j <= right)
            {
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
    }
}
