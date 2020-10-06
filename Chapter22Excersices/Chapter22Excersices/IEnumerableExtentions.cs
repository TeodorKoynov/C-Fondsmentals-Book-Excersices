using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.RegularExpressions;

namespace Chapter22Excersices
{
    public static class IEnumerableExtentions
    {
        public static string ToString<T>(this IEnumerable<T> enumeration)
        {
            StringBuilder enumSting = new StringBuilder();
            enumSting.Append("[ ");
            foreach (T item in enumeration)
            {
                enumSting.Append(item.ToString());
                enumSting.Append(", ");

            }
            if (enumSting.Length > 2)
            {
                enumSting.Remove(enumSting.Length - 2, 2);
            }
            enumSting.Append(" ]");
            return enumSting.ToString();
        }
    }
}
