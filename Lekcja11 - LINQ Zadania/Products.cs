using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja11___LINQ_Zadania
{

    public class Store
    {
        public Product[] products { get; set; }
        public int total { get; set; }
        public int skip { get; set; }
        public int limit { get; set; }
    }

    public class Product
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int price { get; set; }
        public float discountPercentage { get; set; }
        public float rating { get; set; }
        public int stock { get; set; }
        public string brand { get; set; }
        public string category { get; set; }
        public string thumbnail { get; set; }
        public string[] images { get; set; }
    }

}
