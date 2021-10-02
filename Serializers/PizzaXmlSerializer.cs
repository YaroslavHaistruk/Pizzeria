using Pizzeria.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pizzeria.Serializers
{
    class PizzaXmlSerializer
    {
        public static void Serialize(Pizza pizza, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Pizza));
            TextWriter textWriter = new StreamWriter(filePath);
            serializer.Serialize(textWriter, pizza);
            textWriter.Close();
        }
        public static Pizza Deserialize(string filePath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Pizza));
            TextReader textReader = new StreamReader(filePath);
            Pizza product = (Pizza)deserializer.Deserialize(textReader);
            textReader.Close();
            return product;
        }
    }
}
