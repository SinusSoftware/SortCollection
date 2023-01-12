namespace System.Linq
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Reflection;

    //Test for Linq Extensions
    public static partial class LinqExtension
    {

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithBubbleSortByDescending<T>(this IEnumerable<T> source)
        {
            return SortingAlgorithm.SortWithBubbleSort(source, 0, source.Count(), Comparer<T>.Default);
        }

        //[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        //public static IEnumerable<T> SortWithBubbleSort<T>(this IEnumerable<T> source, Func<T, int> sortProperty)
        //{
        //    return SortingAlgorithm.SortWithBubbleSort(source, 0, source.Count(), Comparer<T>.Default);
        //}

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithBubbleSort<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            IComparer<TKey> comparer = Comparer<TKey>.Default;

            TSource[] sortMe = source.ToArray();
            TKey value = sortProperty(sortMe[0]);
            int count = sortMe.Length;
            int index = 0;

            for (int i = 1; i < count + index; i++)
            {
                for (int j = index; j < (count + index - i); j++)
                {
                    if (comparer.Compare(sortProperty(sortMe[j]), sortProperty(sortMe[j+1])) == 1)
                    {
                        TSource temp = sortMe[j];
                        sortMe[j] = sortMe[j + 1];
                        sortMe[j + 1] = temp;
                    }
                }
            }

            return sortMe;
        }

        public static bool IsNullOrEmpty<TSource>(this IEnumerable<TSource>? source)
        {
            if (source is null)
            {
                return true;
            }

            return !source.Any();
        }

        public static bool IsNullOrEmpty(this IEnumerable? source)
        {
            if (source is null)
            {
                return true;
            }

            if (source is ICollection collection)
            {
                return collection.Count == 0;
            }

            var enumerator = source.GetEnumerator();
            return !enumerator.MoveNext();
        }
    }
}
