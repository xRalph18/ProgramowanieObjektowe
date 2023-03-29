using Lekcja11___LINQ_Zadania;
using Newtonsoft.Json;

class Program
{
    public static void Main()
    {
        string path = "products.json";
        string fileData = File.ReadAllText(path);

        var data = JsonConvert.DeserializeObject<Store>(fileData);

        var sumAllIPhonePrice = data.products
            .Where(n => n.brand == "Apple" && n.category == "smartphones")
            .Sum(n => n.price * n.stock);

        Console.WriteLine(sumAllIPhonePrice);
        Console.WriteLine();

        var mostExpensive3 = data.products
            .OrderBy(n => n.price)
            .Take(3);
        var cheapest3 = data.products
            .OrderByDescending(n => n.price)
            .Take(3);

        foreach (var item in mostExpensive3)
        {
            Console.WriteLine($"- {item.title} | {item.price}");
        }

        foreach (var item in cheapest3)
        {
            Console.WriteLine($"= {item.title} | {item.price}");
        }
        Console.WriteLine();

        var averagePriceCategory = data.products
            .GroupBy(n => n.category)
            .Select(n => new { Category = n.Key, AvgPrice = n.Average(n => n.price) });

        var maxPriceCategoty = data.products
            .GroupBy(n => n.category)
            .Select(n => new { Category = n.Key, MaxPrice = n.Max(n => n.price) });

        var minPriceCategoty = data.products
            .GroupBy(n => n.category)
            .Select(n => new { Category = n.Key, MinPrice = n.Min(n => n.price) });

        Console.WriteLine("Avg");

        foreach (var item in averagePriceCategory)
        {
            Console.WriteLine($"{item.Category} - {item.AvgPrice}");
        }

        Console.WriteLine("\nMax");

        foreach (var item in maxPriceCategoty)
        {
            Console.WriteLine($"{item.Category} - {item.MaxPrice}");
        }

        Console.WriteLine("\nMin");

        foreach (var item in minPriceCategoty)
        {
            Console.WriteLine($"{item.Category} - {item.MinPrice}");
        }

        Console.WriteLine();

        var biggestDiscount = data.products
            .OrderBy(n => n.discountPercentage)
            .Where(n => n.category == "smartphones")
            .Select(n => new { Name = n.title, Price = n.price, Discount = n.discountPercentage })
            .Take(10);

        foreach (var item in biggestDiscount)
        {
            Console.WriteLine($"{item.Name} [ {item.Price}$ ] - {item.Discount}%");
        }

        Console.WriteLine();

        var priceOfSkincare = data.products
            .Where(n => n.category == "skincare")
            .Sum(n => n.price);

        Console.WriteLine($"{priceOfSkincare}$");
    }
}