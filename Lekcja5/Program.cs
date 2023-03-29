namespace AutoTaxi
{
    class Auto
    {
        float[] przebieg;
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
            this.przebieg = new float[przebieg.Length];

            for (int i = 0; i < przebieg.Length; i++)
            {
                this.przebieg[i] = przebieg[i];
            }
        }

        public Auto() : this(new float[12] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 })
        {

        }
    }

    class Taxi : Auto
    {
        float[] zarobki;
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
            this.zarobki = new float[zarobki.Length];

            for (int i = 0; i < zarobki.Length; i++)
            {
                this.zarobki[i] = zarobki[i];
            }
        }
    }
}
namespace Figura
{
    abstract class Figura
    {
        public abstract double Pole();
        public abstract double Obwod();
        public virtual void Wyswietl()
        {
            Console.WriteLine($"Pole: {Pole()}, Obwod: {Obwod()}");
        }
    }

    class Prostokat : Figura
    {
        double a, b;

        public Prostokat(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double Obwod()
        {
            return 2 * a + 2 * b;
        }

        public override double Pole()
        {
            return a * b;
        }

        public override void Wyswietl()
        {
            Console.WriteLine("Prostokąt");
            base.Wyswietl();
        }
    }

    class Kolo : Figura
    {
        double r;

        public Kolo(double r)
        {
            this.r = r;
        }

        public override double Obwod()
        {
            return 2 * Math.PI * r;
        }

        public override double Pole()
        {
            return Math.PI * (r * r);
        }

        public override void Wyswietl()
        {
            Console.WriteLine("Koło");
            base.Wyswietl();
        }
    }

    class Trojkat : Figura
    {
        double a, b, c;

        public Trojkat(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double Obwod()
        {
            return a + b + c;
        }

        public override double Pole()
        {
            if (a + b > c && a + c > b && b + c > a)
            {
                double p = (a + b + c) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
            else
            {
                throw new Exception("Podane boki nie tworzą trójkąta!");
            }
        }

        public override void Wyswietl()
        {
            Console.WriteLine("Trojkat");
            base.Wyswietl();
        }
    }
}

class Program
{
    static void Main()
    {
        //cz1
        //float[] tabPrzebieg = new float[12] { 1000, 24563212, 31, 4146873, 23455, 766, 127, 878, 249, 410, 1511, 312 };
        //float[] tabZarobki = new float[12] { 100, 212, 3, 7, 1234, 86, 45, 560, 452, 10, 911, 1200 };

        //var taksowka = new Taxi(tabPrzebieg, tabZarobki);
        //Console.WriteLine($"Średni Przebieg: {taksowka.srPrzebieg()}");
        //Console.WriteLine($"Średnie Zarobki: {taksowka.srZarobki()}");

        // cz2
        //Figura f1 = new Prostokat(2, 3);
        //f1.Wyswietl();

        //Figura f2 = new Kolo(5);
        //f2.Wyswietl();

        //Figura f3 = new Trojkat(5, 5, 3);
        //f3.Wyswietl();

        //cz3

    }
}