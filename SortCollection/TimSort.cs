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
    public static class TimSort
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithTimSort<T>(this IEnumerable<T> source)
        {
            return source;
            //return SortWithBubbleSort(source, 0, source.Count(), Comparer<T>.Default);
        }
    }
}
