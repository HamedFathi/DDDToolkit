using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDDToolkit
{
    public static class Extensions
    {
        public static bool SafeAny<T>(this IEnumerable<T> @this)
            => @this != null && @this.Any();

        public static bool SafeAny<T>(this IEnumerable<T> @this, Func<T, bool> predicate)
            => @this != null && @this.Any(predicate);
    }
}
