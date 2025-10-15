namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class ParallelQuickSortAsync
    {

        #region Ascending

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelQuickSortAsync<T>(this IEnumerable<T> source, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelQuickSortAsync(source, 0, source.Count(), Comparer<T>.Default, source => source, false, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelQuickSortAsync<T>(this IEnumerable<T> source, int index, int count, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelQuickSortAsync(source, index, count, Comparer<T>.Default, source => source, false, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelQuickSortAsync<T>(this IEnumerable<T> source, IComparer<T> comparer, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelQuickSortAsync(source, 0, source.Count(), comparer, source => source, false, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelQuickSortAsync<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelQuickSortAsync(source, index, count, comparer, source => source, false, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<TSource>> SortWithParallelQuickSortByAsync<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelQuickSortAsync(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<TSource>> SortWithParallelQuickSortByAsync<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelQuickSortAsync(source, index, count, Comparer<TKey>.Default, sortProperty, false, cancellationToken);
        }

        #endregion

        #region Descending

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelQuickSortAsyncDescending<T>(this IEnumerable<T> source, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelQuickSortAsync(source, 0, source.Count(), Comparer<T>.Default, source => source, true, cancellationToken); ;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelQuickSortAsyncDescending<T>(this IEnumerable<T> source, int index, int count, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelQuickSortAsync(source, index, count, Comparer<T>.Default, source => source, true, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelQuickSortAsyncDescending<T>(this IEnumerable<T> source, IComparer<T> comparer, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelQuickSortAsync(source, 0, source.Count(), comparer, source => source, true, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelQuickSortAsyncDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelQuickSortAsync(source, index, count, comparer, source => source, true, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<TSource>> SortWithParallelQuickSortByDescendingAsync<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelQuickSortAsync(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, true, cancellationToken);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<TSource>> SortWithParallelQuickSortByDescendingAsync<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelQuickSortAsync(source, index, count, Comparer<TKey>.Default, sortProperty, true, cancellationToken);
        }

        #endregion


        private static async Task<IEnumerable<TSource>> SortWithParallelQuickSortAsync<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, bool descending, CancellationToken cancellationToken)
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
                throw new ArgumentException("Count must be greater than number of elements in source minus index");
            }


            comparer ??= Comparer<TKey>.Default;
            int order = descending ? 1 : -1;
            TSource[] sortMe = source.ToArray();

            int startIndex = index;
            int endIndex = index + count - 1;

            await QuickSortParallelAsync(sortMe, startIndex, endIndex, 0, comparer, sortProperty, order, cancellationToken);

            return sortMe;
        }

        private static async Task QuickSortParallelAsync<TSource, TKey>(TSource[] array, int startIndex, int endIndex, int depth, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (startIndex >= endIndex)
                return;

            int pivotIndex = QuickSort.Partition(ref array, startIndex, endIndex, comparer, sortProperty, order);

            if (depth < Environment.ProcessorCount)
            {
                await Task.WhenAll(
                    QuickSortParallelAsync(array, startIndex, pivotIndex - 1, depth + 1, comparer, sortProperty, order, cancellationToken),
                    QuickSortParallelAsync(array, pivotIndex + 1, endIndex, depth + 1, comparer, sortProperty, order, cancellationToken)
               ).ConfigureAwait(false);
            }
            else
            {
                await QuickSortSequentialAsync(array, startIndex, pivotIndex - 1, depth, comparer, sortProperty, order, cancellationToken);
                await QuickSortSequentialAsync(array, pivotIndex + 1, endIndex, depth, comparer, sortProperty, order, cancellationToken);
            }
        }

        private static async Task QuickSortSequentialAsync<TSource, TKey>(TSource[] array, int startIndex, int endIndex, int depth, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (startIndex >= endIndex)
                return;

            int pivotIndex = QuickSort.Partition(ref array, startIndex, endIndex, comparer, sortProperty, order);
            await QuickSortSequentialAsync(array, startIndex, pivotIndex - 1, depth, comparer, sortProperty, order, cancellationToken);
            await QuickSortSequentialAsync(array, pivotIndex + 1, endIndex, depth, comparer, sortProperty, order, cancellationToken);
        }
    }
}
