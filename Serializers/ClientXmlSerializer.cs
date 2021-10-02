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
    class ClientXmlSerializer
    {
        public static void Serialize(Client client, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Client));
            TextWriter textWriter = new StreamWriter(filePath);
            serializer.Serialize(textWriter, client);
            textWriter.Close();
        }
        public static Client Deserialize(string filePath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Client));
            TextReader textReader = new StreamReader(filePath);
            Client client = (Client)deserializer.Deserialize(textReader);
            textReader.Close();
            return client;
        }
    }
}
