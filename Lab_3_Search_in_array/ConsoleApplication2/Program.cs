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
            int y = 0;
            //zadayemo massyv
            int[,] int_array = new int[2, 2];
            // initzializuemo massyv
            int_array[0, 0] = 2;
            int_array[1, 0] = 4;
            int_array[0, 1] = 5;
            int_array[1, 1] = 3;

            //vvedyt shukane chyslo 
            Console.WriteLine("Vvedyt shukane chyslo");
            int x = Convert.ToInt16(Console.ReadLine());

            for (int i = 0; i < int_array.GetLength(0); i++)
            {
                for (int j = 0; j < int_array.GetLength(1); j++)
                {
                    if (int_array[i, j] == x)
                    {
                        Console.WriteLine("Pozitsiya shukanogo elementa v massyvi i={0}, j={1}", i, j);
                    }
                    else if (int_array[i, j] != x)
                    {
                        y = y + 1;
                    }
                }
            }

            if (y == int_array.GetLength(0) + int_array.GetLength(1))
            {
                Console.WriteLine("Poshuk ne dav rezultatu");
            }
            Console.ReadLine();
        }
    }
}
