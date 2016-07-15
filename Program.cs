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
            try
            {
                try
                {
                    int i;
                    int j;
                    int[,] k = new int[3, 3];
                    Console.WriteLine("Initzializuem massyv, vvedyt dany");
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            k[i, j] = Convert.ToInt16(Console.ReadLine());
                        }
                    }

                    Console.WriteLine("Vkazhyt' index neobhidnogo chysla z massyvy");
                    i = Convert.ToInt16(Console.ReadLine());
                    j = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("Shukane chyslo {0}", k[i, j]);
                    Console.WriteLine("Vvedyt' bud' yake chyslo");
                    int x = Convert.ToInt16(Console.ReadLine());
                    int result = k[i, j] / x;
                    Console.WriteLine("Rezultat dilennya " + result);
                }

                catch (OverflowException e)
                {
                    Console.WriteLine("Vy vvely zavelyke abo zamale znachennya"+e.Message);
                }

                catch (FormatException ex)
                {
                    Console.WriteLine("Vy vvely nekoretny dani"+ex.Message);
                }

                catch (DivideByZeroException)
                {
                    Console.WriteLine("Vy namagalysya podility na nol");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Vy vyishly za mezhy massivy");
                } 
            }

            catch (Exception exc)
                {
                Console.WriteLine("Vy poslalysya na neisnuyche posylannya"+exc.Message);
                throw new NullReferenceException();
                }

            Console.ReadLine();
        }
    }
}
