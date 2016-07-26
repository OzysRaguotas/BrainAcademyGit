using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_GetEnumerator
{
   
   
  
    class Program
    {
        static void Main(string[] args)
        {
            Zoo MyZoo = new Zoo();
            foreach (Animal a in MyZoo)
            {
                Console.WriteLine("{0}--{1}--{2}--{3}", a.Specie, a.Name, a.Color, a.Age.ToString());
            }
            Console.ReadLine();
        }
    }
}
