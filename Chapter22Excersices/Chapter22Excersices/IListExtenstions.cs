using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Chapter22Excersices
{
    public static class IListExtenstions
    {
        public static void IncreseWith(this IList<int> list, int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] += value;
            }
        }
    }
}
