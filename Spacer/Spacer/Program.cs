using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "I'm a black rainbow, I'm an ape of God, I got a face that's made for violence upon";
            char char1 = ' ';
            for (int i = 0; i < string1.Length; i++)
            {
                if (string1[i] != char1)
                {
                    string string2 = Convert.ToString(string1[i]);
                    Console.Write("{0}", string2);
                }
            }
            Console.ReadLine();
        }
    }
}

