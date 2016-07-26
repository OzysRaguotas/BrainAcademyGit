using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_2_Events
{   // declare delegate
    delegate void MyDel();
    class Program
    {
        static void Main()
        {
            //create new event
            MyEvent MyEv = new MyEvent();
            //create subscribers
            CustomerInformation customer1 = new CustomerInformation("Ivan", "Kovalyov", 988888888);
            CustomerInformation customer2 = new CustomerInformation("Andrii", "Sukhorukov", 97777777);
            CustomerInformation customer3 = new CustomerInformation("Oleksiy", "Uhlov", 638888888);

            // add handler
            MyEv.Add += customer1.CIHandler;
            MyEv.Add += customer2.CIHandler;
            MyEv.Add += customer3.CIHandler;
            // start event
            MyEv.OnAdd();

            Console.ReadLine();
        }
    }
}
