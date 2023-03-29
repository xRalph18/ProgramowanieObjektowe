public class ZadEgzamin
{
    public static void fillTab(int[] tab, int lastNumber)
    {
        for (int i = 0; i < tab.Length - 1; i++)
        {
            var rand = new Random();
            int j = rand.Next(1, 100);
            tab[i] = j;
        }

        tab[50] = lastNumber;
    }

    public static int searchTab(int[] tab, int searchedNumber)
    {
        int i = 0;

        while(i < tab.Length)
        {
            if (tab[i] == searchedNumber && i != 50)
            {
                return i;
            }

            i++;
        }

        return -1;
    }

    public static void printTab(int[] tab)
    {
        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine($"{i} - {tab[i]}, ");
        }
    }

    public static void Main()
    {
        int[] tab = new int[51];
        Console.WriteLine("Podaj liczbę, którą chcesz znaleźć: ");
        int searchedNumber = int.Parse(Console.ReadLine());

        fillTab(tab, searchedNumber);
        printTab(tab);

        int searchStatus = searchTab(tab, searchedNumber);

        if (searchStatus == -1)
        {
            Console.WriteLine($"Nieodnaleziono szukanej liczby {searchedNumber}");
        }
        else if(searchTab(tab, searchedNumber) != -1)
        {
            Console.WriteLine($"Szukaną liczbę {searchedNumber} znaleziono w polu nr {searchStatus}");
        }
    }
}