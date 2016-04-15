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
        /// Converts a decimal number into a faction.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static Fraction DecimalToFraction(double num)
        {
            bool isNeg = Util.IsNegative(num);
            int lowerN = 0, lowerD = 1,
                upperN = 1, upperD = 1,
                middleN, middleD;

            num = Math.Abs(num);

            for (;;)
            {
                middleN = lowerN + upperN;
                middleD = lowerD + upperD;

                if (middleD * num < middleN)
                {
                    upperN = middleN;
                    upperD = middleD;
                }
                else if (middleN < num * middleD)
                {
                    lowerN = middleN;
                    lowerD = middleD;
                }
                else
                {
                    return new Fraction((isNeg) ? -middleN : middleN, middleD);
                }
            }
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
            return (num.CompareTo(0) == -1) ? true : false;
        }

        /// <summary>
        /// Determins whether a number is negative or not.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNegative(int num)
        {
            return (num.CompareTo(0) == -1) ? true : false;
        }

        /// <summary>
        /// Determins whether a number is negative or not.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNegative(sbyte num)
        {
            return (num.CompareTo(0) == -1) ? true : false;
        }
        
        /// <summary>
        /// Determins whether a number is negative or not.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNegative(decimal num)
        {
            return (num.CompareTo(0) == -1) ? true : false;
        }
        
        /// <summary>
        /// Determins whether a number is negative or not.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNegative(double num)
        {
            return (num.CompareTo(0) == -1) ? true : false;
        }
        
        /// <summary>
        /// Determins whether a number is negative or not.
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static bool IsNegative(float num)
        {
            return (num.CompareTo(0) == -1) ? true : false;
        }
    }
}
