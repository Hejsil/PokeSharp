using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public struct Fraction
    {
        public bool IsNegative { get; set; }
        public uint Numerator { get; set; }
        public uint Denominator { get; set; }

        public Fraction(uint num = 1, uint denum = 1)
        {
            Numerator = num;
            Denominator = denum;
            IsNegative = false;
        }

        public Fraction(int num = 1, int denum = 1)
        {
            Numerator = (uint)num;
            Denominator = (uint)denum;
            IsNegative = false;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}/{2}", (IsNegative)? "-" : "", Numerator, Denominator);
        }

        public override bool Equals(object obj)
        {
            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return Numerator.GetHashCode() * 17 + Denominator.GetHashCode();
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return new Fraction();
        }
    }
}
