using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lesson4;


namespace lesson5
{
    public class Fraction
    {
        public int numerator;
        public int denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Denominator cannot be zero.");

            this.numerator = numerator;
            this.denominator = denominator;
        }

        // צמצום השבר באמצעות GCD
        private void Reduce()
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;

            // שמירה על מכנה חיובי
            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }

        // חישוב GCD 
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            Fraction result = new Fraction(
                a.numerator * b.denominator + b.numerator * a.denominator,
                a.denominator * b.denominator
            );
            result.Reduce(); 
            return result;
        }

        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction negatedB = new Fraction(-b.numerator, b.denominator);
            return a + negatedB; 
        }

        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction result = new Fraction(
                a.numerator * b.numerator,
                a.denominator * b.denominator
            );
            result.Reduce();
            return result;
        }

        public static Fraction operator /(Fraction a, Fraction b)
        {
            Fraction result = new Fraction(
                a.numerator / b.numerator,
                a.denominator / b.denominator
            );
            result.Reduce();
            return result;
        }

        public static bool operator <(Fraction a, Fraction b)
        {
            int leftNumerator = a.numerator * b.denominator;
            int rightNumerator = b.numerator * a.denominator;

            return leftNumerator < rightNumerator;
        }

        public static bool operator >(Fraction a, Fraction b)
        {
            int leftNumerator = a.numerator * b.denominator;
            int rightNumerator = b.numerator * a.denominator;

            return leftNumerator > rightNumerator;
        }

        public static bool operator <=(Fraction a, Fraction b)
        {
            return a < b || a == b;
        }

        public static bool operator >=(Fraction a, Fraction b)
        {
            return a > b || a == b;
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.numerator * b.denominator == b.numerator * a.denominator;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }


        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }
    }
}
