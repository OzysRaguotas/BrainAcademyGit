using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication25
{ 
class Program
{
    static void factorial(int num, CancellationToken token)
    {int res = 1;
        for (int i = 1; i <= num; i++)
        {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Operation is aborted by token");
                    return;
                }
                res = res * i;
                Console.WriteLine("Factorial of {0} is equal to {1}", i, res);
                Thread.Sleep(3000);
        }         
    }

       public static async Task MyMethodAsync()
        {
            Console.WriteLine("Enter num value");
            int num = Convert.ToInt32(Console.ReadLine());
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;
            Task task1 = new Task(() => factorial(num, token), token);
            Task task2 = task1.ContinueWith((x) => factorial(num, token), token);
            task1.Start();
            Console.WriteLine("Enter x-symbol for operation aborting:");
            string s = Console.ReadLine();
            if (s == "x")
            cancelTokenSource.Cancel();
        }

        static void Main(string[] args)
        {
            MyMethodAsync();
            Console.ReadLine();

        }
    }
}
