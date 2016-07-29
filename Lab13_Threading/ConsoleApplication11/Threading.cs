using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
  public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter number for checking");
            int div = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter step");
            int step = Convert.ToInt32(Console.ReadLine());
            object data = new int[] { div, step };
            Console.WriteLine("Use 'Q' or 'W' bottoms for threading abortion");

            MyThreading MyThread = new MyThreading();
            Thread AddOneThread1 = new Thread(MyThread.AddOne);
            Thread AddOneThread2 = new Thread(MyThread.AddOne);
            Thread AddCustomThread = new Thread(MyThread.AddCustom); 
            Thread StopThread = new Thread(MyThread.STOP);
            StopThread.IsBackground = true;
            AddOneThread1.Start(data);
            AddOneThread2.Start(data);
            AddCustomThread.Start(data);
            StopThread.Start();
            AddOneThread1.Join();
            AddOneThread2.Join();
            AddCustomThread.Join();
            StopThread.Join();
            
            Console.ReadLine();
        }
        public class MyThreading
        {
         public ConsoleKey key;

            public void AddOne(object data)
            {
                int[] dataarr = (int[])data;
                int div = dataarr[0];
                int step = dataarr[1];

                for (int i = 1; i <= 50; i++)
                {
                    if (key == ConsoleKey.Q)
                    {
                        Console.WriteLine("Thread 1 has been aborted");
                        break;
                    }
                    if (i % div == 0)
                    {
                        Console.WriteLine("{0} is divided by {1}", i, div);
                    }
                    Thread.Sleep(500);
                }
            }

            public void AddCustom(object data)
            {
                int[] dataarr = (int[])data;
                int div = dataarr[0];
                int step = dataarr[1];
                for (int i = 1; i <= 200; i = i + step)
                {
                    if (key == ConsoleKey.W)
                    {
                        Console.WriteLine("Thread 2 has been aborted");
                        break;
                    }

                    if (i % div == 0)
                    {
                        Console.WriteLine("{0} is divided by {1}", i, div);
                    }
                    Thread.Sleep(500);
                }
            }

            public void STOP()
            {
                while (key !=ConsoleKey.Q)
                {
                    key = Console.ReadKey().Key;
                }
                while (key != ConsoleKey.W)
                {
                    key = Console.ReadKey().Key;
                }
            }
        }

    }
}

