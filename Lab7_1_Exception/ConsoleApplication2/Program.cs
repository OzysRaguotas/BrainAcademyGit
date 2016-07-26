using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_1_Exceptions
{
 
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int i;
                int j;
                int[,] k = new int[3, 3];
                //k=null; //uncomment if ArgumentNullException is required
                if (k == null)
                {
                    throw new ArgumentNullException(String.Format("Array is not created"));
                }

                try
                {
                    Console.WriteLine("Enter data");
                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            k[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }

                    for (i = 0; i < 3; i++)
                    {
                        for (j = 0; j < 3; j++)
                        {
                            if (k[i, j] == 5)
                            {
                                throw new Exception(String.Format("Element k[{0},{1}] is equal to {2}", i, j, k[i,j]));
                            }
                        }
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("You enter data in incorrect format " + e.Message);
                }

                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Vy vyishly za mezhy massivy"+ex.Message);
                }

            }
            catch (Exception exception)
            {
                Console.WriteLine("Message: {0}, Source of exception: {1}, StackTrace for exception: {2}", exception.Message, exception.Source, exception.StackTrace);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("Message for inner exception:"+ exception.InnerException.Message);
                }
            }


            Console.ReadLine();
        }
    }
}
