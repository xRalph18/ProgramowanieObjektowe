using Lekcja15;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

class Program
{
    public static string ReadFile(string path)
    {
        using (StreamReader fm = new StreamReader(path))
        {
            return fm.ReadToEnd();
        }
    }

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

        var a = ReadFile("cut_joint_reactions.txt").Split("\t");
        foreach (var item in a)
        {
            Console.WriteLine(item);
        }
    }
}