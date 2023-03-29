class Auto
{
    float[] przebieg = new float[12];
    public float srPrzebieg()
    {
        float sum = 0;
        foreach (var item in przebieg)
        {
            sum += item;
        }

        return sum / przebieg.Length;
    }
    public Auto(float[] przebieg)
    {
        this.przebieg = przebieg;
    }
}

class Taxi : Auto
{
    float[] zarobki = new float[12];
    public float srZarobki()
    {
        float sum = 0;
        foreach (var item in zarobki)
        {
            sum += item;
        }

        return sum / zarobki.Length;
    }
    public Taxi(float[] zarobki, float[] przebieg) : base(przebieg)
    {
        this.zarobki = zarobki;
    }
}

class Program
{
    static void Main()
    {
        float[] tabPrzebieg = new float[12] { 1000, 24563212, 31, 4146873, 23455, 766, 127, 878, 249, 410, 1511, 312 };
        float[] tabZarobki = new float[12] { 100.50f, 212.10f, 3.99f, 7.27f, 1234.50f, 86.40f, 45.46f, 560.09f, 452.20f, 10.10f, 911.12f, 1200.00f };

        var taksowka = new Taxi(tabPrzebieg, tabZarobki);
        Console.WriteLine(taksowka.srPrzebieg());
        Console.WriteLine(taksowka.srZarobki());
    }
}