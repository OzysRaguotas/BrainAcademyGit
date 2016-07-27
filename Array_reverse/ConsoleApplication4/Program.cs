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
            int[] MyArr1 = new int[6];
            int[] MyArr2 = new int[6];
            Console.WriteLine("Vvedyt' element masivu");

            for (int i = 0; i < 6; i++)
            {
                MyArr1[i] = Convert.ToInt16(Console.ReadLine());
            }

            // Reversuemo masyv za dopomogoyu masyvy MyArr2
            int j = 0;
            for (int i = 5; i >= 0; i--)
            {
                MyArr2[j] = MyArr1[i];
                j++;
            }

            Console.WriteLine("Reversovanyi masyv:");

            for (j = 0; j < 6; j++)
            { Console.WriteLine(MyArr2[j]); }
            Console.ReadLine();
        }
    }
}
}
