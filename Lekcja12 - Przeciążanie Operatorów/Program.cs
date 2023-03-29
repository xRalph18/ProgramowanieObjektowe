using Lekcja12___Przeciążanie_Operatorów;

class Program
{
    public static void Main()
    {
        double[] tab1 = new double[] { 1, 5, 3, 7, 3, 5 };
        double[] tab2 = new double[] { 6, 8, 2, 5, 8, 1 };
        double[] tab3 = new double[] { 1, 5, 3, 7, 3, 5 };

        Vector vector1 = new Vector(tab1);
        Vector vector2 = new Vector(tab2);

        var v3 = vector1 + vector2;
        var v4 = vector1 - vector2;
        var v5 = vector1 * vector2;
        var v6 = (double)vector1;
        var v7 = (string)vector1;
        var v8 = vector1.ToString();
        var v9 = tab1 == tab3;

        v3.Display();
        v4.Display();
        Console.WriteLine($"[ {v5} ]");
        Console.WriteLine($"[ {v6} ]");
        Console.WriteLine($"{v7}");
        Console.WriteLine($"{v8}");
        Console.WriteLine($"[ {v9} ]");
    }
}