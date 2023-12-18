namespace System
{
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// Wraps static sort apis into a uniform extension method api.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public static partial class ShakerSort
    {
        #region Ascending

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSort<T>(this IEnumerable<T> source)
        {
            return SortWithShakerSort(source, 0, source.Count(), Comparer<T>.Default, source => source, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSort<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithShakerSort(source, index, count, Comparer<T>.Default, source => source, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSort<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithShakerSort(source, 0, source.Count(), comparer, source => source, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSort<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithShakerSort(source, index, count, comparer, source => source, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithShakerSortBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithShakerSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, false);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithShakerSortBy<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithShakerSort(source, index, count, Comparer<TKey>.Default, sortProperty, false);
        }

        #endregion

        #region Descending

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSortDescending<T>(this IEnumerable<T> source)
        {
            return SortWithShakerSort(source, 0, source.Count(), Comparer<T>.Default, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSortDescending<T>(this IEnumerable<T> source, int index, int count)
        {
            return SortWithShakerSort(source, index, count, Comparer<T>.Default, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSortDescending<T>(this IEnumerable<T> source, IComparer<T> comparer)
        {
            return SortWithShakerSort(source, 0, source.Count(), comparer, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> SortWithShakerSortDescending<T>(this IEnumerable<T> source, int index, int count, IComparer<T> comparer)
        {
            return SortWithShakerSort(source, index, count, comparer, source => source, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithShakerSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> sortProperty)
        {
            return SortWithShakerSort(source, 0, source.Count(), Comparer<TKey>.Default, sortProperty, true);
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<TSource> SortWithShakerSortByDescending<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, Func<TSource, TKey> sortProperty)
        {
            return SortWithShakerSort(source, index, count, Comparer<TKey>.Default, sortProperty, true);
        }

        #endregion

        private static IEnumerable<TSource> SortWithShakerSort<TSource, TKey>(this IEnumerable<TSource> source, int index, int count, IComparer<TKey> comparer, Func<TSource, TKey> sortProperty, bool descending)
        {
            //if (index < 0)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(index), index, "The index can't be less than 0.");
            //}

            //if (count < 0)
            //{
            //    throw new ArgumentOutOfRangeException(nameof(count), count, "The count can't be less than 0.");
            //}

            //if (source.Count() - index < count)
            //{
            //    throw new ArgumentException("Count must be greater than number of elements in source minus index");
            //}

            comparer ??= Comparer<TKey>.Default;
            int order = descending ? -1 : 1;

            TSource[] sortMe = source.ToArray();

            for (var i = index; i < count / 2; i++)
            {
                var swapFlag = false;

                //for (var j = i; j < count - i - 1; j++)
                for (var j = i; j < count - i - 1 + index; j++)
                {
                    //if (array[j] > array[j + 1])
                    if (comparer.Compare(sortProperty(sortMe[j]), sortProperty(sortMe[j + 1])) == order)
                    {
                        //Swap(ref array[j], ref array[j + 1]);
                        Swap(ref sortMe[j], ref sortMe[j + 1]);
                        //TSource temp = sortMe[j];
                        //sortMe[j] = sortMe[j + 1];
                        //sortMe[j + 1] = temp;

                        swapFlag = true;
                    }
                }

                //for (var j = count - 2 - i; j > i; j--)
                //for (var j = count - 2 - i + index+1; j > i; j--)
                    for (var j = count - 2 - i + index; j > i; j--)
                    {
                    //if (array[j - 1] > array[j])
                    if (comparer.Compare(sortProperty(sortMe[j - 1]), sortProperty(sortMe[j])) == order)
                    {
                        //Swap(ref array[j - 1], ref array[j]);
                        Swap(ref sortMe[j - 1], ref sortMe[j]);
                        //TSource temp = sortMe[j];
                        //sortMe[j - 1] = sortMe[j];
                        //sortMe[j - 1] = temp;

                        swapFlag = true;
                    }
                }

                if (!swapFlag)
                {
                    break;
                }
            }

            return sortMe;
        }

        private static void Swap<TSource>(ref TSource e1, ref TSource e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
    }
}
