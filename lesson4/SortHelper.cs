using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4
{
    internal class SortHelper
    {
        public static void SortTwoA<T>(ref T first, ref T second, Comparison<T> comparison)
        {
            if (comparison(first, second) > 0)
            {
                T temp = first;
                first = second;
                second = temp;
            }
        }

        public static void SortTwoB<T>(ref T first, ref T second) where T : IComparable<T>
        {
            if (first.CompareTo(second) > 0)
            {
                T temp = first;
                first = second;
                second = temp;
            }
        }
    }
}
