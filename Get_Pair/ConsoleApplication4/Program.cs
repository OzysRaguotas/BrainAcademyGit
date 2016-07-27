using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArr = new int[100];
            for (int i = 0; i < 100; i++)
            {
                MyArr[i] = i + 1;
            }
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(MyArr[i]);
            }
            for (int i = 0; i < 100; i++)
            {
                if (MyArr[i] % 2 == 0)
                {
                    Console.WriteLine(MyArr[i]);
                }

            }
            Console.ReadLine();
        }
    }
}

