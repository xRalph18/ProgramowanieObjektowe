using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja12___Przeciążanie_Operatorów
{
    public class Vector
    {
        double[] data;

        public Vector(double[] dataToCopy)
        {
            data = new double[dataToCopy.Length];

            for (int i = 0; i < dataToCopy.Length; i++)
            {
                data[i] = dataToCopy[i];
            }
        }

        public void Display()
        {
            Console.Write("[ ");
            foreach (var item in data)
            {
                Console.Write($"{item}, ");
            }
            Console.Write("]");
        }

        public static Vector operator + (Vector v1, Vector v2)
        {
            if(v1.data.Length != v2.data.Length)
            {
                throw new Exception("Tabs have different length");
            }

            var result = new Vector(v1.data);

            for (int i = 0; i < v1.data.Length; i++)
            {
                result.data[i] += v2.data[i];
            }

            return result;
        }

        public static Vector operator - (Vector v1, Vector v2)
        {
            if(v1.data.Length != v2.data.Length)
            {
                throw new Exception("Tabs have different lenght");
            }

            var result = new Vector(v1.data);

            for (int i = 0; i < v1.data.Length; i++)
            {
                result.data[i] -= v2.data[i];
            }

            return result;
        }

        public static double operator * (Vector v1, Vector v2)
        {
            if (v1.data.Length != v2.data.Length)
            {
                throw new Exception("Tabs have different lenght");
            }

            double result = 0;

            for (int i = 0; i < v2.data.Length; i++)
            {
                result += v1.data[i] * v2.data[i];
            }

            return result;
        }

        public static explicit operator double (Vector v1)
        {
            double result = 0;

            for (int i = 0; i < v1.data.Length; i++)
            {
                result += v1.data[i] * v1.data[i];
            }

            result = Math.Sqrt(result);

            return result;
        }

        public static explicit operator string (Vector v1)
        {
            string result = "[ ";

            for (int i = 0; i < v1.data.Length; i++)
            {
                result += v1.data[i] + ", ";
            }

            result += "]";

            return result;
        }

        public override string ToString()
        {
            return (string)this;
        }

        public static bool operator == (Vector v1, Vector v2)
        {
            bool result = true;

            for (int i = 0; i < v1.data.Length; i++)
            {
                if (v1.data[i] != v2.data[i])
                {
                    result = false;
                    break;
                }
            }

            return result;
        }

        public static bool operator != (Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }

        public override bool Equals(object? obj)
        {
            return this == (Vector)obj;
        }
    }
}
