namespace System.Linq
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Reflection;

    //Test for Linq Extensions
    public static partial class LinqExtension
    {
      
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
