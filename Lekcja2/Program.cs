class Lekcja2
{
    static void WelcomeMessage(string name)
    {
        Console.WriteLine($"Witaj {name}!");
    }

    // Zad.1
    // Wygeneruj tabliczkę mnożenia dla zakresu liczb podanego w parametrach metody
    // TabliczkaMnozenia(1,5)

    static void TabliczkaMnozenia(int min, int max)
    {
        for (int wiersz = min; wiersz <= max; wiersz++)
        {
            for (int kol = min; kol <= max; kol++)
            {
                Console.Write($"{wiersz * kol}\t");
            }
            Console.WriteLine();
        }

    }

    // Zad.2.1
    // Napisz metodę obliczającą maksymalną oraz średnią pensję n pracowników, gdzie n jest parametrem metody i oznacza liczbę pracowników,
    // pensja pracowników jest wczytywana w pętli wewnątrz metody. Maksymalną i średnią pensję należy zwrócić na liście parametrów
    // double sredniaPensja, maksPensja;
    // LiczPensje(10, sredniaPensja, maksPensja);
    // Dobrze ale nie w pełni według polecenia

    static void LiczPensje(int n)
    {
        double pensja, avgPensja = 0, maxPensja = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Podaj pensję {i + 1} pracownika");
            pensja = double.Parse(Console.ReadLine());
            avgPensja += pensja;
            if (maxPensja < pensja)
            {
                maxPensja = pensja;
            }
            else
            {
                continue;
            }
        }
        Console.WriteLine($"Średnia pensja: {avgPensja / n}");
        Console.WriteLine($"Najwyższa pensja: {maxPensja}");
    }

    // 2.2

    static void LiczPensje2(int n, ref double avgPensja, ref double maxPensja)
    {
        double pensja;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Podaj pensję {i + 1} pracownika");
            pensja = double.Parse(Console.ReadLine());
            avgPensja += pensja;
            if (maxPensja < pensja)
            {
                maxPensja = pensja;
            }
            else
            {
                continue;
            }
        }
        avgPensja /= n;
    }

    // Zad.3 Utwóż metodę sortującą 3 liczby od najmniejszej do największej

    static void Sortuj(ref int a, ref int b, ref int c)
    {
        int storage;

        if (a > b)
        {
            storage = a;
            a = b;
            b = storage;
        }
        if (b > c)
        {
            storage = b;
            b = c;
            c = storage;
        }
        if (a > b)
        {
            storage = a;
            a = b;
            b = storage;
        }
    }

    static void Main()
    {
        // Zad.1 - TabliczkaMnozenia(1, 10);
        // Zad.2.1 - LiczPensje(10);
        /* 2.2
        double avgPensja = 0, maxPensja = 0;
        LiczPensje2(10, ref avgPensja, ref maxPensja);
        Console.WriteLine(avgPensja);
        Console.WriteLine(maxPensja);
        */
        /* Zad.3
        int a = 10, b = 7, c = 8;
        Sortuj(ref a, ref b, ref c);
        Console.WriteLine($"a = {a} \t b = {b} \t c = {c}");
        */
    }
}