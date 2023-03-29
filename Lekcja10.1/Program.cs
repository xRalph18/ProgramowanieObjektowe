using Lekcja10._1;
using Newtonsoft.Json;
using System.Text.Json.Nodes;

class Program
{
    static void Main()
    {
        string path = "mock_products.json";
        string fileData = File.ReadAllText(path);

        var data = JsonConvert.DeserializeObject<List<Products>>(fileData);

        //foreach (var item in data.Take(10))
        //{
        //    Console.WriteLine($"{item.Id} | {item.Name} {item.Producer} | {item.UnitPrice} | {item.UnitsInStock}");
        //}

        //var priceMore10k = data
        //    .Where(x => x.UnitPrice > 10_000)
        //    .Select(x => new { Nazwa = x.Name, Producent = x.Producer });

        //foreach (var item in priceMore10k)
        //{
        //    Console.WriteLine($"Nazwa: {item.Nazwa} | Producent: {item.Producent}");
        //}

        var cheapest = data
            .OrderBy(x => x.UnitPrice)
            .Select(x => new { Nazwa = x.Name, Producent = x.Producer })
            .Take(1);

        var mostExpensive = data
            .OrderByDescending(x => x.UnitPrice)
            .Select(x => new { Nazwa = x.Name, Producent = x.Producer })
            .Take(1);

        foreach (var item in cheapest)
        {
            Console.WriteLine($"Najtańszy jest {item.Nazwa} od {item.Producent}");
        }

        foreach (var item in mostExpensive)
        {
            Console.WriteLine($"Najdroższy jest {item.Nazwa} od {item.Producent}");
        }
    }
}