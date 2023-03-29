using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja9.Model
{
    public class Hotel
    {
        [Index(0)]
        public string Lp { get; set; }
        [Index(1)]
        public string NazwaWlasna { get; set; }
        [Index(2)]
        public string Telefon { get; set; }
        [Index(3)]
        public string Email { get; set; }
        [Index(4)]
        public string CharakterUslug { get; set; }
        [Index(5)]
        public string KategoriaObiektu { get; set; }
        [Index(6)]
        public string RodzajObiektu { get; set; }
        [Index(7)]
        public string Adres { get; set; }
    }
}
