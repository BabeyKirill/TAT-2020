using System;
using System.IO;
using System.Xml.Serialization;

namespace DEV_2._1
{
    class DatabaseManager
    {
        public static void XmlDeserialize(ref object objectForDeserializing, string databaseXmlFileName)
        {
            XmlSerializer formatter = new XmlSerializer(objectForDeserializing.GetType());

            using (FileStream fs = new FileStream($"../../{databaseXmlFileName}.xml", FileMode.Open))
            {
                objectForDeserializing = Convert.ChangeType(formatter.Deserialize(fs), objectForDeserializing.GetType());
            }
        }

        public static void XmlSerialize(object objectForSerializing, string databaseXmlFileName)
        {
            XmlSerializer formatter = new XmlSerializer(objectForSerializing.GetType());

            using (FileStream fs = new FileStream($"../../{databaseXmlFileName}.xml", FileMode.Create))
            {
                formatter.Serialize(fs, objectForSerializing);
            }
        }
    }
}