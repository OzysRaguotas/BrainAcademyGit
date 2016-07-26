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
    static int factorial(int num, CancellationToken token)
    {int res = 1;
        for (int i = 1; i <= num; i++)
        {
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Operation is aborted by token");
                    return 0;
                }
                res = res * i;
                Console.WriteLine("Factorial of {0} is equal to {1}", i, res);
                Thread.Sleep(300);               
        }
     return res;
}

       public static int FactorialOperationAsync()
        {
            Console.WriteLine("Enter num value");
            int num = Convert.ToInt32(Console.ReadLine());
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;
            Task <int> task1 = new Task<int>(() => factorial(num, token), token);
            Task <int> task2 = task1.ContinueWith((x) => x.Result);
            task1.Start();
            
            Console.WriteLine("Enter x-symbol for operation aborting:");
            string s = Console.ReadLine();
            if (s == "x")
            cancelTokenSource.Cancel();
            return task1.Result;
        }

        public static async void MyMethodAsync()
        {
            CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
            CancellationToken token = cancelTokenSource.Token;
            Console.WriteLine("Enter num value");
            int num = Convert.ToInt32(Console.ReadLine());
            //Task<int> task3 = new Task<int>(() => factorial(num, token), token);

            int result = await Task<int>.Factory.StartNew(() => factorial(num, token), token);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            MyMethodAsync();
            Console.ReadLine();

        }
    }
}
