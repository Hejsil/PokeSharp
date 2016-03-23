using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class Utility
    {
        public static uint GreatestCommonDivider(uint u, uint v)
        {
            int shift;

            if (u == 0) return v;
            if (v == 0) return u;

            for (shift = 0; ((u | v) & 1) == 0; shift++)
            {
                u >>= 1;
                v >>= 1;
            }

            while ((u & v) == 0)
                u >>= 1;

            do
            {
                while ((v & 1) == 0)
                    v >>= 1;

                if (u > v)
                    Swap(ref u, ref v);

                v -= u;
            } while (v != 0);

            return u << shift;
        }

        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        
        public static bool IsNegative(long num)
        {
            return (num.CompareTo(0) == -1) ? true : false;
        }

        public static bool IsNegative(int num)
        {
            return (num.CompareTo(0) == -1) ? true : false;
        }

        public static bool IsNegative(sbyte num)
        {
            return (num.CompareTo(0) == -1) ? true : false;
        }

        public static bool IsNegative(decimal num)
        {
            return (num.CompareTo(0) == -1) ? true : false;
        }

        public static bool IsNegative(double num)
        {
            return (num.CompareTo(0) == -1) ? true : false;
        }

        public static bool IsNegative(float num)
        {
            return (num.CompareTo(0) == -1) ? true : false;
        }
    }
}
