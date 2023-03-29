using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace Json {
    class Program
    {
        public static void Main()
        {
            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = DateTime.UtcNow.AddDays(30);
            product.Sizes = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);
            File.WriteAllText("JsonFiles/product.json", json);

            var jsonPath = File.ReadAllText("JsonFiles/product.json");
            var jsonReaded = JsonConvert.DeserializeObject<Product>(jsonPath);

            Console.WriteLine($"Name: {jsonReaded.Name}");
            Console.WriteLine($"Expiry: {jsonReaded.Expiry.ToString("dd/MM/yyyy HH:mm")}");
            Console.WriteLine($"Sizes: {jsonReaded.Sizes[0]}");
        }
    }
}