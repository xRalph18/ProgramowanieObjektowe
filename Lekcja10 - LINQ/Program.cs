class Program
{
    public static void TabFill(int[] tab)
    {
        Random rand = new Random();
        
        for(int i = 0; i < tab.Length; i++)
        {
            tab[i] = rand.Next(0, 10);
        }
    }

    static void Main()
    {
        int[] Tab20 = new int[20];
        string[] intPL = new string[] {"zero", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć"};
        TabFill(Tab20);

        var parzyste = Tab20.Where(x => x%2 == 0).ToArray();
        var polskie = Tab20.Select(x => intPL[x]).ToArray();
        var dziel3 = Tab20.Where(x => x%3 == 0).Select(x => x + 5).ToArray();

        foreach (var item in parzyste)
        {
            Console.WriteLine($"{item}, ");
        }

        Console.WriteLine();

        foreach (var item in polskie)
        {
            Console.WriteLine($"{item}, ");
        }

        Console.WriteLine();

        foreach (var item in dziel3)
        {
            Console.WriteLine($"{item}, ");
        }
    }
}