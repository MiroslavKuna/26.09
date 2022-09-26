using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._09
{
    internal class Complex
    {
        private int real;
        private int imagine;

        public Complex(int real, int imagine)
        {
            Real = real;
            Imagine = imagine;
        }

        public int Real { get => real; set => real = value; }
        public int Imagine { get => imagine; set => imagine = value; }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imagine + b.Imagine);
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imagine - b.Imagine);
        }
        public override string ToString()
        {
            return Real+" + "+Imagine+"i";
        }
        public static bool operator ==(Complex a, Complex b) 
        {
            return a.Real == b.Real && a.Imagine == b.Imagine;
        }
        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }
    }
}
