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
        int m, n, i = 0;
        int a = 1;
        int b = 1;
        Console.WriteLine("Tsya programa rozrahovye poslidovnist tsilyh chysel ryady Fibonacci");
        Console.WriteLine("Vvedit bazhanu dovzhinu ryadu");

        n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Rezultat");

        if (n == 0)
        {
            Console.WriteLine(n);
        }

        else if (n == 1)
        {
            Console.WriteLine(n - 1);
            Console.WriteLine(n);
        }

        else if (n >= 2)
        {
            Console.WriteLine(0);
            Console.WriteLine(1);

            for (i = 0; i < n; i = i + 1)
            {
                m = a + b;
                a = b;
                b = m;

                Console.WriteLine(m);
            }
        }
        Console.ReadLine();
    }
}
}
