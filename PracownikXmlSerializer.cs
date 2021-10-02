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
    class PracownikXmlSerializer
    {
        public static void Serialize(Pracownik pracownik, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Pracownik));
            TextWriter textWriter = new StreamWriter(filePath);
            serializer.Serialize(textWriter, pracownik);
            textWriter.Close();
        }
        public static Pracownik Deserialize(string filePath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(Pracownik));
            TextReader textReader = new StreamReader(filePath);
            Pracownik pracownik = (Pracownik)deserializer.Deserialize(textReader);
            textReader.Close();
            return pracownik;
        }
    }

}
