using Lekcja16___Atrybuty.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja16___Atrybuty
{
    [Author("Rafał")]
    [Author("Maja", Version = "v0.7.1")]
    [IsTested("Class Test")]
    class Project
    {
        [IsTested("Property Test")]
        public int TestProperty { get; set; }

        [IsTested("Method Test")]
        public static void DisplayInt(int number)
        {
            Console.WriteLine($"Number is: {number}");
        }
    }

    [Author("Julia", Version = "v1.0")]
    [IsTested("Struct Test")]
    struct Person { }
}
