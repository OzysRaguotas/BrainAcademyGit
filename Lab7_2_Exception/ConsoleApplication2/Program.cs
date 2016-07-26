using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_2_Exception
{
    class MyException1 : Exception
    {
        public MyException1() { }

        public MyException1(string message) : base(message) { }

        public MyException1(string message, Exception inner) : base(message, inner) { }

    }

    class MyException2 : Exception
    {
        public MyException2() { }

        public MyException2(string message) : base(message) { }

        public MyException2(string message, Exception inner) : base(message, inner) { }

    }

    class MyException3 : Exception
    {
        public MyException3() { }

        public MyException3(string message) : base(message) { }

        public MyException3(string message, Exception inner) : base(message, inner) { }

    }

    public class MyArray
    {
        int i;
        int j;
        int[,] k = new int[3, 3];

        public void GetArray()
        {
            Console.WriteLine("Enter data");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    k[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void GetElement()
        {
            Console.WriteLine("Enter the searching index");
            i = Convert.ToInt16(Console.ReadLine());
            j = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Searching integer {0}", k[i, j]);
        }

        public void CheckLines()
        {
            Console.WriteLine("Check the sum of array lines using Custom Exception1");
            int[] sum = new int[3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    sum[i] += k[i, j];
                }
                if (sum[i] > 10) throw new MyException1();
            }
        }

        public void CheckColumns()
        {
            Console.WriteLine("Check the sum of array columns using Custom Exception2");
            int[] sum1 = new int[3];
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    sum1[i] += k[j, i];
                }
                if (sum1[i] > 10) throw new MyException2();
            }
        }

        public void CheckSum()
        {
            Console.WriteLine("Check the sum of array columns using Custom Exception2");
            int sum2 = 0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    sum2 += k[j, i];
                }
                if (sum2 > 20) throw new MyException3();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {
                    MyArray arr = new MyArray();
                    arr.GetArray();
                    arr.GetElement();
                    arr.CheckLines();
                    arr.CheckColumns();
                    arr.CheckSum();
                }

                catch (FormatException e)
                {
                    Console.WriteLine("Vy vvely nekoretny dani /n" + e.Message);
                }

                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Vy vyishly za mezhy massivy");
                }

            }
            catch (MyException1 ex)
            {
                Console.WriteLine("The sum of array lines is bigger than 10 " + ex.Message);
                string writePath = @"C:\Users\Слава\Desktop\Exception1.txt";
                System.IO.File.WriteAllText(writePath, ex.StackTrace);
            }
            catch (MyException2 exc)
            {
                Console.WriteLine("The sum of array columns is bigger than 10 " + exc.Message);
                string writePath = @"C:\Desktop\Exception2.txt";
                Console.WriteLine(exc.Data);

                System.IO.File.WriteAllText(writePath, exc.StackTrace);
            }
            catch (MyException3 excep)
            {
                Console.WriteLine("The sum of array elements is bigger than 20 " + excep.Message);
                string writePath = @"C:\Desktop\Exception3.txt";
                System.IO.File.WriteAllText(writePath, excep.Source);
            }

            Console.ReadLine();
        }
    }
}
