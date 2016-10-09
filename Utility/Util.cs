using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    /// <summary>
    /// A static class containing utility methods.
    /// </summary>
    public static class Util
    {
        private static readonly Random _rand = new Random();

        public static void EnsureSize<T>(IEnumerable<T> collection, int size)
        {
            if (collection.Count() > size || collection.Count() < size)
                throw new IndexOutOfRangeException("Collection didn't uphold the size ensurence of " + size + " elements.");
        }

        public static double RandomDouble()
        {
            return _rand.NextDouble();
        }

        public static int RandomInt(int min = int.MinValue, int max = int.MaxValue - 1)
        {
            return _rand.Next(min, max + 1);
        }

        public static int RandomChoice(params int[] chances)
        {
            int number = RandomInt(0, chances.Sum() - 1);
            for (int i = 0; i < chances.Length; i++)
            {
                if (number < chances[i])
                {
                    return i;
                }

                number -= chances[i];
            }

            return -1;
        }

        /// <summary>
        /// Cap a number so that it is alway equal or below a max
        /// </summary>
        /// <param name="num"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int CapAbove(int num, int max)
        {
            return (num > max) ? max : num;
        }

        /// <summary>
        /// Cap a number so that it is alway equal or above a min
        /// </summary>
        /// <param name="num"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static int CapBelow(int num, int min)
        {
            return (num < min) ? min : num;
        }

        /// <summary>
        /// Cap a number so that it is alway equal to min or max, or between them
        /// </summary>
        /// <param name="num"></param>
        /// <param name="min"></param>
        /// <returns></returns>
        public static int Cap(int num, int min, int max)
        {
            return (num < min) ? min : ((num > max) ? max : num);
        }

        /// <summary>
        /// Find greatest common divider of many numbers.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int GreatestCommonDivider(params int[] numbers)
        {
            return numbers.Aggregate(GreatestCommonDivider);

        }
        /// <summary>
        /// Find greatest common divider of many numbers.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns></returns>
        public static int GreatestCommonDivider(IEnumerable<int> numbers)
        {
            return numbers.Aggregate(GreatestCommonDivider);
        }

        /// <summary>
        /// Find greatest common divider of two numbers.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="v"></param>
        /// <returns></returns>
        public static int GreatestCommonDivider(int a, int b)
        {
            int temp;

            while (b != 0)
            {
                temp = a;
                a = b;
                b = temp % b;
            }

            return a;
        }

        /// <summary>
        /// Swaps to variable values with each other.
        /// </summary>
        /// <typeparam name="T">Type of the variable to swap.</typeparam>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        
        /// <summary>
        /// Determins whether a number is negative or not.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNegative(long num)
        {
            return num.CompareTo(0) == -1;
        }

        /// <summary>
        /// Determins whether a number is negative or not.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNegative(int num)
        {
            return num.CompareTo(0) == -1;
        }

        /// <summary>
        /// Determins whether a number is negative or not.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNegative(sbyte num)
        {
            return num.CompareTo(0) == -1;
        }
        
        /// <summary>
        /// Determins whether a number is negative or not.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNegative(decimal num)
        {
            return num.CompareTo(0) == -1;
        }
        
        /// <summary>
        /// Determins whether a number is negative or not.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNegative(double num)
        {
            return num.CompareTo(0) == -1;
        }
        
        /// <summary>
        /// Determins whether a number is negative or not.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNegative(float num)
        {
            return num.CompareTo(0) == -1;
        }
    }
}
