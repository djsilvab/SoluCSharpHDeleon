using System;
using SoluCSharp.Fund.Demo01.Models;
using System.Text.Json;

namespace SoluCSharp.Fund.Demo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo de Serializacion-Deserializacion!");
            //SerializarToJson();
            DeserializarToObject();
            Console.ReadLine();

        }

        static void SerializarToJson()
        {
            Console.WriteLine("Serializacion!");
            Cerveza oCerveza = new Cerveza("tres cruces", 10);
            string jsonCerveza = JsonSerializer.Serialize(oCerveza);

            System.IO.File.WriteAllText("objeto.txt", jsonCerveza);
        }

        static void DeserializarToObject()
        {
            var jsonCerveza = System.IO.File.ReadAllText("objeto.txt");
            Cerveza oCerveza = JsonSerializer.Deserialize<Cerveza>(jsonCerveza);
            Console.WriteLine(oCerveza);
        }
    }
}
