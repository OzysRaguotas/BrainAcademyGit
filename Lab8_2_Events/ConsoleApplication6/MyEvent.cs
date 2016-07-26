using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_2_Events
{
    class MyEvent
    { //Declare event
        public event MyDel Add;
        // Use method for delegates start
        public void OnAdd()
        {
            Add();
        }
    }
}
