using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace APMPattern
{
    public delegate int DisplayHandler(int k);
    class Program
    {
        static DisplayHandler handler;

        static int Display(int k)
        {
            Console.WriteLine("Enter factorial lenght");
            int l = Convert.ToInt32(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= l; i++)
            {
                result *= i;
            }
            return result;
        }
        static void AsyncCompleted(IAsyncResult resObj)
        {
            string mes = (string)resObj.AsyncState;
            Console.WriteLine(mes);
            Console.WriteLine("Asynchronious delegate work has been finished");
        }

        static IAsyncResult BeginFunction()
        {
            handler = new DisplayHandler(Display);
            IAsyncResult resultObj = handler.BeginInvoke(10, new AsyncCallback(AsyncCompleted), "Asynchroniuos callback completed");
            return resultObj;
        }

        static void EndFunction(IAsyncResult resultObj)
        {
            int res = handler.EndInvoke(resultObj);
            Console.WriteLine("Searching factorial: {0}", res); }

        static void Main(string[] args)
        {
            IAsyncResult resobj;
            resobj = Program.BeginFunction();
            Program.EndFunction(resobj);
            Console.ReadLine();
        }
    }
}

