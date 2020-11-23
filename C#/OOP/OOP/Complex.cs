using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Complex
    {
        private int _real, _imaginary;

        public Complex() : this(0, 0){}
        public Complex(int real, int imaginary)
        {
            _real = real;
            _imaginary = imaginary;
        }

        public int Real { get; set; }
        public int Imaginary { get; set; }

        public override string ToString()
        {
            return _real + " + " + _imaginary + "i";
        }

        public static Complex operator+(Complex c1, Complex c2)
        {
            return new Complex(c1._real + c2._real, c1._imaginary + c2._imaginary);
        }
    }
}
