using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace Serialization
{
    [Serializable]
    public class Student
    {
       public string ID { get; set;}
       public string Group { get; set; }
       public string SIDNumber { get; set; }
       public double AvRating { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var SerializableStudent = new Student { ID = "SR800542", Group = "EK-35", SIDNumber = "AB900456", AvRating=4.53 };

            //Serialization
            IFormatter binFormatter = new BinaryFormatter();
            IFormatter soapFormatter = new SoapFormatter();
            XmlSerializer xmlSer = new XmlSerializer(typeof(Student));
            //streams
            Stream binStream = new FileStream("BinFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream soapStream = new FileStream("SoapFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
            Stream xmlStream = new FileStream("XmlFile.xml", FileMode.Create, FileAccess.Write, FileShare.None);

            binFormatter.Serialize(binStream, SerializableStudent);
            soapFormatter.Serialize(soapStream, SerializableStudent);
            xmlSer.Serialize(xmlStream, SerializableStudent);

            binStream.Close();
            soapStream.Close();
            xmlStream.Close();

            Console.WriteLine("Object is serialized");

            // Deseriialization
            IFormatter binReadFormatter = new BinaryFormatter();
            IFormatter soapReadFormatter = new SoapFormatter();
            XmlSerializer xmlReadSer = new XmlSerializer(typeof(Student));

            Stream binReadStream = new FileStream("BinFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            Stream soapReadStream = new FileStream("SoapFile.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            FileStream xmlReadStream = new FileStream("XmlFile.xml", FileMode.Open, FileAccess.Read, FileShare.Read);

            Student st1 = (Student)binReadFormatter.Deserialize(binReadStream);
            Student st2 = (Student)soapReadFormatter.Deserialize(soapReadStream);
            Student st3 = (Student)xmlReadSer.Deserialize(xmlReadStream);

            binReadStream.Close();
            soapReadStream.Close();
            xmlReadStream.Close();

            Console.WriteLine("Binary: ID - {0}, Group - {1}, Student ID Number - {2}, Average Rating - {3}", st1.ID, st1.Group, st1.SIDNumber, st1.AvRating);
            Console.WriteLine("SOAP: ID - {0}, Group - {1}, Student ID Number - {2}, Average Rating - {3}", st2.ID, st2.Group, st2.SIDNumber, st2.AvRating);
            Console.WriteLine("XML: ID - {0}, Group - {1}, Student ID Number - {2}, Average Rating - {3}", st3.ID, st3.Group, st3.SIDNumber, st3.AvRating);

            Console.ReadLine();
        }
    }
}
