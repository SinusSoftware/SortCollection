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

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static async Task<IEnumerable<T>>  SortWithParallelQuickSortAsync<T>(this IEnumerable<T> source, CancellationToken cancellationToken = default)
        {
            //return SortWithParallelQuickSort(source, 0, source.Count(), Comparer<T>.Default, source => source, false);
            return null;
        }
    }
}
