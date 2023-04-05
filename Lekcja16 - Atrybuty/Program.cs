using Lekcja16___Atrybuty;
using Lekcja16___Atrybuty.Attributes;
using System.Reflection;

class Program
{
    public static void Main()
    {
        Type projekt = typeof(Project);

        foreach (Object attributes in projekt.GetCustomAttributes(false))
        {
            Author autor = attributes as Author;

            if (null != autor)
            {
                Console.WriteLine($"Name: {autor.Name}");
                Console.WriteLine($"Version: {autor.Version}");
            }
        }

        Console.WriteLine();

        Type osoba = typeof(Person);

        foreach (Object attributes in osoba.GetCustomAttributes(false))
        {
            Author autor = attributes as Author;

            if (null != autor)
            {
                Console.WriteLine($"Name: {autor.Name}");
                Console.WriteLine($"Version: {autor.Version}");
            }
        }

        Console.WriteLine();

        foreach (Object attributes in projekt.GetCustomAttributes(false))
        {
            IsTested testing = attributes as IsTested;

            if (null != testing)
            {
                Console.WriteLine($"Test Message: {testing}");
            }
        }

        foreach (Object attributes in osoba.GetCustomAttributes(false))
        {
            IsTested testing = attributes as IsTested;

            if (null != testing)
            {
                Console.WriteLine($"Test Message: {testing}");
            }
        }

        foreach (MethodInfo m in projekt.GetMethods())
        {
            foreach (Attribute a in m.GetCustomAttributes(false))
            {
                IsTested testing = a as IsTested;

                if (null != testing)
                {
                    Console.WriteLine($"Test Message: {testing}");
                }
            }
        }

        foreach (PropertyInfo m in projekt.GetProperties())
        {
            foreach (Attribute a in m.GetCustomAttributes(false))
            {
                IsTested testing = a as IsTested;

                if (null != testing)
                {
                    Console.WriteLine($"Test Message: {testing}");
                }
            }
        }




    }
}