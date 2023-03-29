using CsvHelper.Configuration;
using CsvHelper;
using System.Globalization;
using Lekcja11___Zadania2.Model;

class Program
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

            var grouppedHotelsType = hotele
                .GroupBy(n => n.RodzajObiektu)
                .Select(n => new { Category = n.Key, ObjectsInType = n.Count() });

            var grouppedHotelsCategory = hotele
                .GroupBy(n => n.KategoriaObiektu)
                .Select(n => new { Category = n.Key, ObjectsInCategory = n.Count() });

            var grouppedHotelsService = hotele
                .GroupBy(n => n.CharakterUslug)
                .Select(n => new { Category = n.Key, ObjectsInService = n.Count() });

            foreach (var item in grouppedHotelsType)
            {
                Console.WriteLine($"{item.Category} - {item.ObjectsInType}");
            }

            Console.WriteLine();

            foreach (var item in grouppedHotelsCategory)
            {
                Console.WriteLine($"{item.Category} - {item.ObjectsInCategory}");
            }

            Console.WriteLine();

            foreach (var item in grouppedHotelsService)
            {
                Console.WriteLine($"{item.Category} - {item.ObjectsInService}");
            }
        }
    }
}