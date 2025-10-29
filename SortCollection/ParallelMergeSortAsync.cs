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
    public static partial class ParallelMergeSortAsync
    {
        #region Ascending

        /// <summary>
        /// Sorts the elements multithreading and async in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelMergeSortAsync<T>(this IEnumerable<T> source, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelMergeSortAsync(source, 0, source.Count(), Comparer<T>.Default, source => source, false, cancellationToken);
        }

        /// <summary>
        /// Sorts the elements multithreading and async in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelMergeSortAsync<T>(this IEnumerable<T> source, int index, int count, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelMergeSortAsync(source, index, count, Comparer<T>.Default, source => source, false, cancellationToken);
        }

        /// <summary>
        /// Sorts the elements multithreading and async in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelMergeSortAsync<T>(this IEnumerable<T> source, IComparer<T> comparer, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelMergeSortAsync(source, 0, source.Count(), comparer, source => source, false, cancellationToken);
        }

        /// <summary>
        /// Sorts the elements multithreading and async in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
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
        public static async Task<IEnumerable<T>> SortWithParallelMergeSortAsync<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelMergeSortAsync(source, index, count, comparer, source => source, false, cancellationToken);
        }

        /// <summary>
        /// Sorts the elements multithreading and async in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<TSource>> SortWithParallelMergeSortByAsync<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelMergeSortAsync(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false, cancellationToken);
        }

        /// <summary>
        /// Sorts the elements multithreading and async in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
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
        public static async Task<IEnumerable<TSource>> SortWithParallelMergeSortByAsync<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelMergeSortAsync(source, index, count, Comparer<TKey>.Default, sortProperty, false, cancellationToken);
        }

        #endregion

        #region Descending

        /// <summary>
        /// Sorts the elements descending multithreading and async in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelMergeSortAsyncDescending<T>(this IEnumerable<T> source, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelMergeSortAsync(source, 0, source.Count(), Comparer<T>.Default, source => source, true, cancellationToken); ;
        }

        /// <summary>
        /// Sorts the elements descending multithreading and async in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the default comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="index">The zero-based starting index of the range to sort.</param>
        /// <param name="count">The length of the range to sort.</param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="ArgumentOutOfRangeException">index is less than 0 or count is less than 0.</exception>
        /// <exception cref="ArgumentException">index and count do not specify a valid range in the <see cref="IEnumerable{T}"/></exception>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelMergeSortAsyncDescending<T>(this IEnumerable<T> source, int index, int count, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelMergeSortAsync(source, index, count, Comparer<T>.Default, source => source, true, cancellationToken);
        }

        /// <summary>
        /// Sorts the elements descending, multithreading and async in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="comparer">The System.Collections.Generic.IComparer implementation to use when comparing
        /// elements, or null to use the default comparer System.Collections.Generic.Comparer.Default.
        /// </param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>> SortWithParallelMergeSortAsyncDescending<T>(this IEnumerable<T> source, IComparer<T> comparer, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelMergeSortAsync(source, 0, source.Count(), comparer, source => source, true, cancellationToken);
        }

        /// <summary>
        /// Sorts the elements descending, multithreading and async in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
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
        public static async Task<IEnumerable<T>> SortWithParallelMergeSortAsyncDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelMergeSortAsync(source, index, count, comparer, source => source, true, cancellationToken);
        }

        /// <summary>
        /// Sorts the elements descending, multithreading and async in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes
        /// </summary>
        /// <param name="sortProperty">Specified the compare element.</param>
        /// <param name="cancellationToken">The cancellation token that cancels the sorting operation</param>
        /// <exception cref="OperationCanceledException">Is thrown when the task is cancelled via <paramref name="cancellationToken"/></exception>
        /// <exception cref="ObjectDisposedException">Is thrown when try to access the object is already been disposed</exception>
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<TSource>> SortWithParallelMergeSortByDescendingAsync<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelMergeSortAsync(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, true, cancellationToken);
        }

        /// <summary>
        /// Sorts the elements descending, multithreading and async in a range of elements in <see cref="IEnumerable{T}"/><br/>
        /// using the specified comparer.<br/>
        /// Worst Case Time Complexity[Big - O]: O(n* log n)<br/>
        /// Best Case Time Complexity[Big - omega]: O(n* log n)<br/>
        /// Average Time Complexity[Big - theta]: O(n* log n)<br/>
        /// Space Complexity: O(n)<br/>
        /// Stable: Yes 
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
        public static async Task<IEnumerable<TSource>> SortWithParallelMergeSortByDescendingAsync<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty, CancellationToken cancellationToken = default)
        {
            return await SortWithParallelMergeSortAsync(source, index, count, Comparer<TKey>.Default, sortProperty, true, cancellationToken);
        }

        #endregion


        private static async Task<IEnumerable<TSource>> SortWithParallelMergeSortAsync<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey>? comparer, Func<TSource, TKey> sortProperty, bool descending, CancellationToken cancellationToken = default)
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

            var array = source.ToArray();

            await MergeSortParallelAsync(array, index, count - 1 + index, 0, Environment.ProcessorCount, comparer, sortProperty, order, cancellationToken)
                                        .ConfigureAwait(false);

            return array;

        }

        private static async Task MergeSortParallelAsync<TSource, TKey>(TSource[] array, int left, int right, int depth, int maxDepth, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (left >= right)
                return;

            int middle = (left + right) / 2;

            if (depth < maxDepth)
            {
                await Task.WhenAll(
                    MergeSortParallelAsync(array, left, middle, depth + 1, maxDepth, comparer, sortProperty, order, cancellationToken),
                    MergeSortParallelAsync(array, middle + 1, right, depth + 1, maxDepth, comparer, sortProperty, order, cancellationToken)
                ).ConfigureAwait(false);
            }
            else
            {
                await MergeSortSequentialAsync(array, left, middle, comparer, sortProperty, order, cancellationToken);
                await MergeSortSequentialAsync(array, middle + 1, right, comparer, sortProperty, order, cancellationToken);
            }

            MergeSort.Merge(array, left, middle, right, comparer, sortProperty, order);
        }

        private static async Task MergeSortSequentialAsync<TSource, TKey>(TSource[] array, int left, int right, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, int order, CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            if (left >= right)
                return;

            int middle = (left + right) / 2;
            await MergeSortSequentialAsync(array, left, middle, comparer, sortProperty, order, cancellationToken);
            await MergeSortSequentialAsync(array, middle + 1, right, comparer, sortProperty, order, cancellationToken);
            MergeSort.Merge(array, left, middle, right, comparer, sortProperty, order);
        }
    }
}
