using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja16___Atrybuty.Attributes
{
    [AttributeUsage(
        AttributeTargets.Class |
        AttributeTargets.Struct,
        AllowMultiple = true)]
    public class Author : Attribute
    {
        public string Name { get; set; }
        public string Version { get; set; }

        public Author(string name)
        {
            Name = name;
        }

        public string version
        {
            get
            {
                return Version;
            }
            set
            {
                Version = value;
            }
        }
    }
}
