using Lekcja13___Operatory_CD;

class Program
{
    public static void Main()
    {
        var complex1 = new Complex(2, 3);
        var complex2 = new Complex(2, -3);
        var complex3 = new Complex(2, 3);
        var complex4 = new Complex(1, 2);
        var complex5 = new Complex(3, 4);

        Console.WriteLine(complex1.ToString());
        Console.WriteLine((string)complex2);

        Console.WriteLine(complex1 == complex3);
        Console.WriteLine(complex1 != complex3);
        Console.WriteLine(complex1.Equals(complex3));

        Console.WriteLine(complex4 + complex5);
        Console.WriteLine(complex4 - complex5);

        Console.WriteLine(complex4 * complex5);
        Console.WriteLine((double)complex2);

        Console.WriteLine(complex5[0]);
        Console.WriteLine(complex5[1]);
    }
}