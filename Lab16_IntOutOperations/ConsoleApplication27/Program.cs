using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace InOutOperation
{
   public class IOoperations
    {
        string fileName { get; set;}
        public string currentlocation { get; set;}
       
        public IOoperations()
        {  }
        public IOoperations(string path, string name)
        {
            fileName = name;
            currentlocation = path;
        }

        public IOoperations(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            fileName = fileInfo.Name;
            currentlocation = fileInfo.DirectoryName;
        }


        public void WriteToFile(string message)
        {
            using (StreamWriter stWriter = new StreamWriter(currentlocation+fileName))
            {
                Console.WriteLine("Write to file begin");
                stWriter.WriteLine(message);
                Console.WriteLine("Write to file end");
            }
        }

        public void ReadFromFile()
        {
            using (FileStream fs=new FileStream(currentlocation+fileName, FileMode.Open))
            {
                using (StreamReader stReader = new StreamReader(fs))
                {
                    Console.WriteLine("Read from file begin");
                    Console.WriteLine(stReader.ReadToEnd());
                    Console.WriteLine("Read from file end");
                }
            }
        }

        public void Memory(string message)
        {
            byte[] byteArr = Encoding.ASCII.GetBytes(message);
            MemoryStream ms = new MemoryStream();
            Console.WriteLine("Write to memory begin");
            ms.Write(byteArr, 0, byteArr.Length);
            Console.WriteLine("Read from memory begin");
            Console.WriteLine(Encoding.ASCII.GetString(ms.ToArray()));
        }

        public void WriteAsync(string message)
        {
            using (StreamWriter AstWrt = new StreamWriter(currentlocation + fileName))
            {
                Console.WriteLine("Write to file asinchroniously begin");
                AstWrt.WriteAsync(message);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter message");
            string message = Console.ReadLine();
            string path = @"C:\Users\Слава\Desktop\IOoperations.txt";
           // string name = @"IOoperations.txt";
            IOoperations MyIOop = new IOoperations(path);
            MyIOop.WriteToFile(message);
            MyIOop.ReadFromFile();
            MyIOop.Memory(message);
            MyIOop.WriteAsync(message);
            Console.ReadLine();
        }
    }
}
