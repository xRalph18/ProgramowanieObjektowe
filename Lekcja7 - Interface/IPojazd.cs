using System.Net.Security;

internal interface IPojazd
{
    void Start();
    void Stop();
    void Zwolnij(float v);
    void Przyspiesz(float v);
}

class Samochod : IPojazd
{
    public float Velocity { get; set; } = 80.00f;

    public void Start()
    {
        Console.WriteLine("Startuje");
    }

    public void Stop()
    {
        Console.WriteLine("Zatrzymuję się");
    }

    public void Zwolnij(float v)
    {
        Velocity -= v;
        Console.WriteLine($"Zwalniam o {v}km/h");
    }

    public void Przyspiesz(float v)
    {
        Velocity += v;
        Console.WriteLine($"Przyspieszam o {v}km/h");
    }
}
