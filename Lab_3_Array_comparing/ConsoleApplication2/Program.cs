using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 0;
            int s1 = 0;
            int i, j;
            //zadayemo massyvy
            int[,] int_array = new int[3, 2];
            // initzializuemo pershiy massyv
            int_array[0, 0] = 2;
            int_array[1, 0] = 4;
            int_array[2, 0] = 5;
            int_array[0, 1] = -3;
            int_array[1, 1] = 6;
            int_array[2, 1] = 9;

            int[,] int_array1 = new int[3, 3];
            // initzializuemo drygiy massyv
            int_array1[0, 0] = 2;
            int_array1[1, 0] = 4;
            int_array1[2, 0] = 5;
            int_array1[0, 1] = 3;
            int_array1[1, 1] = -6;
            int_array1[2, 1] = 1;
            int_array1[0, 2] = 5;
            int_array1[1, 2] = 4;
            int_array1[2, 2] = -10;

            // skladayemo elementy massyvyv

            for (i = 0; i < int_array.GetLength(0); i++)
            {
                for (j = 0; j < int_array.GetLength(1); j++)
                {
                    s = s + int_array[i, j];
                }
            }

            for (i = 0; i < int_array1.GetLength(0); i++)
            {
                for (j = 0; j < int_array1.GetLength(1); j++)
                {
                    s1 = s1 + int_array1[i, j];
                }
            }

            if (s == s1)
            {
                Console.WriteLine("Sumy elementyv masyviv odnakovi");
            }
            else if (s > s1)
            {
                Console.WriteLine("Suma elementyv pershogo masyvy bilsha");
            }
            else if (s < s1)
            {
                Console.WriteLine("Suma elementyv drugogo masyvy bilsha");
            }

            Console.ReadLine();
        }
    }
}
