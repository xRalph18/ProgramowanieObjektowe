using Lekcja14___PracaZPlikami;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    public static string SinCos(double start, double step, double end)
    {
        string data = $"{"x", 5};{"sin(x)", 15};{"cos(x)", 15}\n";

        for (double i = start; i <= end; i += step)
        {
            data += $"{Math.Round(i, 1).ToString(CultureInfo.InvariantCulture), 5:N1};" +
                $"{Math.Round(Math.Sin(i), 4).ToString(CultureInfo.InvariantCulture), 15:N4};" +
                $"{Math.Round(Math.Cos(i), 4).ToString(CultureInfo.InvariantCulture), 15:N4}\n";
        }
        return data;
    }

    public static void Main()
    {
        string data = SinCos(0, 0.1, 20);

        FileMethods.WriteFile("sincos.txt", data);
        FileMethods.ReadFile("sincos.txt");
    }
}