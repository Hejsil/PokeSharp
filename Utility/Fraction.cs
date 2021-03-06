﻿namespace Utility
{
    /// <summary>
    /// A fraction data type representing all the rational numbers.
    /// Note. Operations between doubles and fractions can be slow.
    /// </summary>
    public struct Fraction
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        /// <summary>
        /// The decimal value of the fraction.
        /// Setting this property will convert the double to a fraction.
        /// </summary>
        public double Value
        {
            get
            {
                return (double)Numerator / Denominator;
            }
        }

        public Fraction(int num = 1, int denum = 1)
        {
            Numerator = num;
            Denominator = denum;
        }

        /// <summary>
        /// Reduces the fraction using the greatest common divider of the Numerator and Denominator.
        /// </summary>
        public void Reduce()
        {
            int gcd = Util.GreatestCommonDivider(Numerator, Denominator);
            Numerator /= gcd;
            Denominator /= gcd;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            int result = Numerator.GetHashCode();
            result = result * 37 + Denominator.GetHashCode();
            return result;
        }

        #region Operator overloading
        #region TypeCasting
        public static implicit operator Fraction(int a)
        {
            return new Fraction(a, 1);
        }

        public static explicit operator int(Fraction a)
        {
            return (int)a.Value;
        }

        public static explicit operator double(Fraction a)
        {
            return a.Value;
        }
        #endregion

        #region Negative
        public static Fraction operator -(Fraction a)
        {
            a.Numerator = -(a.Numerator);
            return a;
        }
        #endregion

        #region Addition
        public static Fraction operator +(Fraction a, Fraction b)
        {
            a.Numerator = (a.Numerator * b.Denominator) +
                          (b.Numerator * a.Denominator);
            a.Denominator *= b.Denominator;
            return a;
        }

        public static Fraction operator +(Fraction a, int b)
        {
            a.Numerator += b * a.Denominator;
            return a;
        }

        public static Fraction operator +(int a, Fraction b)
        {
            return b + a;
        }
        #endregion

        #region Subtraction
        public static Fraction operator -(Fraction a, Fraction b)
        {
            a.Numerator = (a.Numerator * b.Denominator) -
                          (b.Numerator * a.Denominator);
            a.Denominator *= b.Denominator;
            return a;
        }

        public static Fraction operator -(Fraction a, int b)
        {
            a.Numerator -= b * a.Denominator;
            return a;
        }

        public static Fraction operator -(int a, Fraction b)
        {
            return -b + a;
        }
        #endregion

        #region Multiplication
        public static Fraction operator *(Fraction a, Fraction b)
        {
            a.Numerator *= b.Numerator;
            a.Denominator *= b.Denominator;
            return a;
        }

        public static Fraction operator *(Fraction a, int b)
        {
            a.Numerator *= b;
            return a;
        }

        public static Fraction operator *(int a, Fraction b)
        {
            return b * a;
        }
        #endregion

        #region Division
        public static Fraction operator /(Fraction a, Fraction b)
        {
            a.Numerator *= b.Denominator;
            a.Denominator *= b.Numerator;
            return a;
        }

        public static Fraction operator /(Fraction a, int b)
        {
            a.Denominator *= b;
            return a;
        }

        public static Fraction operator /(int a, Fraction b)
        {
            int temp = a * b.Denominator;
            b.Denominator = b.Numerator;
            b.Numerator = temp;
            return b;
        }
        #endregion
        #endregion
    }
}
