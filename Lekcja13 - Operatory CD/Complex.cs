using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja13___Operatory_CD
{
    public class Complex
    {
        public double Re { get; set; }
        public double Im { get; set; }

        public Complex(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public static explicit operator string(Complex c)
        {
            string result = "";

            if(c.Im >= 0)
            {
                result = $"{c.Re} + {c.Im}i";
            }
            else if(c.Im < 0)
            {
                result = $"{c.Re} - {Math.Abs(c.Im)}i";
            }

            return result;
        }

        public override string ToString()
        {
            return (string)this;
        }

        public static bool operator == (Complex cL, Complex cR)
        {
            return cL.Re == cR.Re && cL.Im == cR.Im;
        }

        public static bool operator != (Complex cL, Complex cR)
        {
            return !(cL == cR);
        }

        public override bool Equals(object? obj)
        {
            return this == (Complex)obj;
        }

        public static Complex operator + (Complex cL, Complex cR)
        {
            double re = cL.Re + cR.Re;
            double im = cL.Im + cR.Im;

            return new Complex(re, im);
        }

        public static Complex operator - (Complex cL, Complex cR)
        {
            double re = cL.Re - cR.Re;
            double im = cL.Im - cR.Im;

            return new Complex(re, im);
        }

        public static Complex operator * (Complex cL, Complex cR)
        {
            double re = (cL.Re * cR.Re - cL.Im * cR.Im);
            double im = (cL.Re * cR.Im + cR.Re * cL.Im);
            return new Complex(re, im);
        }

        public static explicit operator double(Complex c)
        {
            return Math.Abs(Math.Sqrt(Math.Pow(c.Re, 2) + Math.Pow(c.Im, 2)));
        }

        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return this.Re;
                    case 1:
                        return this.Im;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (index)
                {
                    case 0:
                        this.Re = value;
                        break;
                    case 1:
                        this.Im = value;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
