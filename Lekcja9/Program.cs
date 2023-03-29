using CsvHelper;
using CsvHelper.Configuration;
using Lekcja9.Model;
using System.Globalization;
using System.Reflection.PortableExecutable;

namespace Lekcja9
{
    public class Program
    {
        public static void Main()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
            };

            using (var reader = new StreamReader("hotele.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                var hotele = csv.GetRecords<Hotel>().ToList();

                //Console.WriteLine($"Liczba hoteli: {hotele.Count()}");

                //var numQuery =
                //    from hotel in hotele
                //    where hotel.NazwaWlasna.ToLower().StartsWith("b")
                //    select hotel.NazwaWlasna;

                //Console.WriteLine($"Jest {numQuery.Count()} hoteli na literę B \n");

                //foreach (var num in numQuery)
                //{
                //    Console.WriteLine($"{num}, ");
                //}
                //Console.WriteLine();

                var star4Query =
                    from hotel in hotele
                    where hotel.KategoriaObiektu.Length == 4
                    select hotel.NazwaWlasna;

                var star3Query =
                    from hotel in hotele
                    where hotel.KategoriaObiektu.Length == 3
                    select hotel.NazwaWlasna;

                foreach (var star in star4Query)
                {
                    Console.WriteLine($"{star}, ");
                }
                Console.WriteLine();

                foreach (var star in star3Query)
                {
                    Console.WriteLine($"{star}, ");
                }
                Console.WriteLine();

                Console.WriteLine($"Jest {star4Query.Count()} hoteli *4");
                Console.WriteLine($"Jest {star3Query.Count()} hoteli *3");
            }
        }
    }
}