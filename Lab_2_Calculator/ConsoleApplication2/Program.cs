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
            int x, y, res;
            char o;
            char s = '+';
            char d = '/';
            char m = '*';
            char v = '-';

            // zadayemo pershe chyslo
            Console.WriteLine("Vvedit pershe chyslo");
            x = Convert.ToInt16(Console.ReadLine());
            // zadayemo druhe chyslo
            Console.WriteLine("Vvedit druhe chyslo");
            y = Convert.ToInt16(Console.ReadLine());

            // Zadayemo bazhany diy
            Console.WriteLine("Vvedyt bazhanu diy nad chyslamy, +, -, *, /");
            o = Convert.ToChar(Console.ReadLine());

            if (o == s)
            {
                res = x + y;
                Console.WriteLine("Rezultat skladannya " + x + " ta " + y + " = " + res);
            }
            else if (o == v)
            {
                res = x - y;
                Console.WriteLine("Rezultat vidnimannya " + x + " vid " + y + " = " + res);
            }
            else if (o == m)
            {
                res = x * y;
                Console.WriteLine("Rezultat mnozhennya " + x + " na " + y + " = " + res);
            }
            else if (o == d)
            {
                res = x / y;
                Console.WriteLine("Rezultat dilennya " + x + " na " + y + " = " + res);
            }

            Console.ReadLine();
        }
    }
}

