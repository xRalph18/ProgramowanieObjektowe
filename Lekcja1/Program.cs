/* IF
// wczytaj długości boków trójkąta (abc); sprawdź czy może z nich powstać trójkąt; suma 2 boków > od 3;
// typ trójkąta (równoboczny a=b=c; równoramienny a=b || a=c || b=c; prostokątny a^2 + b^2 = c^2 || b^2 + c^2 = a^2 || a^2 + c^2 = b^2; różnoboczny innne)


    Console.WriteLine("Podaj a: ");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Podaj b: ");
    int b = int.Parse(Console.ReadLine());
    Console.WriteLine("Podaj c: ");
    int c = int.Parse(Console.ReadLine());

    Console.WriteLine("");

    if (a + b > c && a + c > b && b + c > a)
    {
        Console.WriteLine("Z podanych boków może powstać trójkąt");
        if (a == b && a == c && b == c)
        {
            Console.WriteLine("Trójkąt jest równoboczny");
        }
        else if (a == b || a == c || b == c)
        {
            Console.WriteLine("Trójkąt jest równoramienny");
        }
        else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
        {
            Console.WriteLine("Trójkąt jest prostokątny");
        }
        else
        {
            Console.WriteLine("Trójkąt jest różnoboczny");
        }
    }
    else
    {
        Console.WriteLine("Z podanych boków nie może powstać trójkąt");
    }

*/

/* SWITCH */
// Zdefiniuj typ ENUM - miesiące; wyświetl miesiąc i liczbę jego dni;

namespace ProgramowanieObiektowe
{
    enum miesiace
    {
        Styczen,
        Luty,
        Marzec,
        Kwiecien,
        Maj,
        Czerwiec,
        Lipiec,
        Sierpien,
        Wrzesien,
        Pazdziernik,
        Listopad,
        Grudzien
    }

    class Lekcja1
    {
        static int Main()
        {
            Console.WriteLine("Podaj numer miesiąca [1-12]");
            int nrMiesiac = int.Parse(Console.ReadLine());
            nrMiesiac -= 1;

            miesiace miesiac = (miesiace)nrMiesiac;

            switch (miesiac)
            {
                case miesiace.Styczen:
                    Console.WriteLine("Styczeń ma 31 dni");
                    break;

                case miesiace.Luty:
                    Console.WriteLine("Luty ma 28 dni");
                    break;

                case miesiace.Marzec:
                    Console.WriteLine("Marzec ma 31 dni");
                    break;

                case miesiace.Kwiecien:
                    Console.WriteLine("Kwiecień ma 30 dni");
                    break;

                case miesiace.Maj:
                    Console.WriteLine("Maj ma 31 dni");
                    break;

                case miesiace.Czerwiec:
                    Console.WriteLine("Czerwiec ma 30 dni");
                    break;

                case miesiace.Lipiec:
                    Console.WriteLine("Liepiec ma 31 dni");
                    break;

                case miesiace.Sierpien:
                    Console.WriteLine("Sierpień ma 31 dni");
                    break;

                case miesiace.Wrzesien:
                    Console.WriteLine("Wrzesień ma 30 dni");
                    break;

                case miesiace.Pazdziernik:
                    Console.WriteLine("Październik ma 31 dni");
                    break;

                case miesiace.Listopad:
                    Console.WriteLine("Listopad ma 30 dni");
                    break;

                case miesiace.Grudzien:
                    Console.WriteLine("Grudzień ma 31 dni");
                    break;
            }

            return 0;
        }
    }
}

// Zad.dom
// Zad.1 > Napisz program sprawdzający, przez jakie ćwiartki układu współrzędnych przechodzi prosta o równaniu [y = ax + b].
// Zad.2 > Napisz program obliczający sumę, iloczyn, max i min dla n liczb losowych w zakresie <1;49>. Liczbę n należy wczytać (Liczby losowe generuje się za pomocą klasy Random).
// Random r = new Random()
// int a = r.Next(1, n);