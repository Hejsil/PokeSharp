using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeSharp.Utility
{
    public static class Util
    {
        public static void EnsureSize<T>(IEnumerable<T> collection, int size)
        {
            if (collection.Count() > size || collection.Count() < size)
                throw new IndexOutOfRangeException("Collection didn't uphold the size ensurence of " + size + " elements.");
        }
    }
}
