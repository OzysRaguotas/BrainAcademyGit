using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class SpeedDescending<T> : IComparer<T>
    where T : Animal
    {
        // Realizuemo IComparer<T>
        public int Compare(T x, T y)
        {
            int tt = "Hello".CompareTo("Allo");
            if (x.MaxSpeed < y.MaxSpeed)
                return 1;
            else if (x.MaxSpeed > y.MaxSpeed)
                return -1;
            else if (x.MaxSpeed == y.MaxSpeed)
                return x.Weight.CompareTo(y.Weight);
            else return 0;
        }
    }
}
