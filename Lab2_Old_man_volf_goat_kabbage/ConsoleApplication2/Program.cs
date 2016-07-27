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
            int a, b, c, d, e, f = 0;
            Console.WriteLine("Umovy zadachy:");
            Console.WriteLine("Didu neobhidno perevezty cherez richku vovka, kozu ta kapustu");
            Console.WriteLine("Vovka na mozhna zalyshaty z kozoy, kozu z kapustoy");
            Console.WriteLine("Obmezhen shchodo kilkosti pereprav ne isnue");
            Console.WriteLine("Dlya poznachennya diy dida vuikorystovyite nastupni chysla:");
            Console.WriteLine("1 - did plyve na inshiy bereg sam");
            Console.WriteLine("2 - did povertaetsya sam");
            Console.WriteLine("3 - did veze na inshiy bereg vovka");
            Console.WriteLine("4 - did povertaetsya z vovkom");
            Console.WriteLine("5 - did veze na inshiy bereg kozu");
            Console.WriteLine("6 - did povertaetsya z kozoy");
            Console.WriteLine("7 - did veze na inshiy bereg kapustu");
            Console.WriteLine("8 - did povertaetsya z kapustoy");

            Console.WriteLine("Vvedyt pershu diy dida");

            a = Convert.ToInt32(Console.ReadLine());//did veze kozu na inshiy bereg
            if (a == 5)
            {
                Console.WriteLine("Vvedyt drugu diy dida");
                b = Convert.ToInt32(Console.ReadLine());//did povertaetsya pustiy
                if (b == 2)
                {
                    Console.WriteLine("Vvedyt trety diy dida");
                    c = Convert.ToInt32(Console.ReadLine());//did veze na inshiy bereg vovka
                    if (c == 3)
                    {
                        Console.WriteLine("Vvedyt chetverty diy dida");
                        d = Convert.ToInt32(Console.ReadLine());//did povertaetsya z kozoy
                        if (d == 7)
                        {
                            Console.WriteLine("Vvedyt shostu diy dida");
                            e = Convert.ToInt32(Console.ReadLine());//did veze na inshiy bereg kapustu
                            if (e == 5)
                            {
                                Console.WriteLine("Vvedyt siomu diy dida");
                                f = Convert.ToInt32(Console.ReadLine());//did povertaetsya pustiy
                                if (f == 5)
                                {
                                    Console.WriteLine("Vy vygraly");//did veze kozu na inshiy bereg
                                }
                                else
                                {
                                    Console.WriteLine("Vy prograly");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Vy prograly");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vy prograly");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Vy prograly");
                    }
                }
                else
                {
                    Console.WriteLine("Vy prograly");
                }
            }
            else
            {
                Console.WriteLine("Vy prograly");
            }
            Console.ReadLine();
        }
    }
}
