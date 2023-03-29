using System.Linq;

class Lekcja3
{
    // Napisz funkcję obliczająca cenę po zniżce default zniżka 5% (cena, zniżka) => (cena po zniżce) cena - (zniżka/100)
    static void ObliczZnizke(double cena, double znizka = 5)
    {
        Console.WriteLine(cena - ((znizka / 100) * cena));
    }

    // Napisz funkcję
    static double ObliczZawartoscKoszyka(params double[] koszyk)
    {
        return koszyk.Sum();
    }

    // Napisz 2 funkcje, 1 która wprowadza dane do tabllicy i 2 która wyświetla dane z tablicy
    static void WczytajTablice1D(double[] tab)
    {
        double liczba;

        // wczytujemy dane z klawiatury
        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine("Wprowadź liczbę: ");
            liczba = double.Parse(Console.ReadLine());
            tab[i] = liczba;
        }
    }

    static void WyswietlTablice1D(double[] tab)
    {
        foreach (var item in tab)
        {
            Console.Write($"{item}\t");
        }
    }

    // Napisz kod funkcji, która oblicza iloczyn skalarny (2 tablice (t1[1 5 7 8], t2[2 1 2 3]), t1*t2 = 1*2 + 5*1 + 7*2 + 8*4)
    static void IloczynSkalarny(double[] tab1, double[] tab2)
    {
        double iloczynSkal = 0;

        if (tab1.Length == tab2.Length)
        {
            for (int i = 0; i < tab1.Length; i++)
            {
                iloczynSkal += tab1[i] * tab2[i];
            }
            Console.WriteLine($"Iloczyn skalarny wynosi: {iloczynSkal}");
        }
        else
        {
            throw new Exception("Tablice nie mają równej długości");
        }
    }

    // t1 + t2
    static void SumujTablice(double[] tab1, double[] tab2)
    {
        double[] tab3 = new double[tab1.Length];

        if (tab1.Length == tab2.Length)
        {
            for (int i = 0; i < tab1.Length; i++)
            {
                tab3[i] = tab1[i] + tab2[i];
            }
            foreach (var item in tab3)
            {
                Console.Write($"{item}\t");
            }
        }
        else
        {
            throw new Exception("Tablice nie mają równej długości");
        }
    }

    static void Main()
    {
        // ObliczZnizke(100);

        // Console.WriteLine(ObliczZawartoscKoszyka(10));
        // Console.WriteLine(ObliczZawartoscKoszyka(10, 20));
        // Console.WriteLine(ObliczZawartoscKoszyka(10, 20, 30));

        // double[] tablica = new double[5];
        // WczytajTablice1D(tablica);
        // WyswietlTablice1D(tablica);

        // double[] t1 = new double[] {1, 5, 7, 8};
        // double[] t2 = new double[] {2, 1, 2, 3};
        // IloczynSkalarny(t1, t2);

        double[] t1 = new double[] { 1, 5, 7, 8 };
        double[] t2 = new double[] { 2, 1, 2, 3 };
        SumujTablice(t1, t2);

    }
}