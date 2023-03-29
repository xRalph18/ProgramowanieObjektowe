using Lekcja15;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

class Program
{
    public static void Main()
    {
        Person person = new Person() { Name = "John Doe", Age = 30 };
        XmlSerializer serializer = new XmlSerializer(typeof(Person));

        // 1 na raz
        //StreamWriter writerXML = new StreamWriter("person.xml");
        //serializer.Serialize(writerXML, person);

        // 1 na raz
        StreamReader reader = new StreamReader("person.xml");
        Person person1 = (Person)serializer.Deserialize(reader);

        //Console.WriteLine($"{person1.Name}, {person1.Age}");

        var a = File.ReadAllLines("cut_joint_reactions.txt");

        foreach (var item in a)
        {
            var b = item.Split("\t");
            foreach (var item1 in b)
            {
                Console.WriteLine(item1);
            }
        }
    }
}