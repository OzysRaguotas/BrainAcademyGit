using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class WeightAscending<T> : IComparer<T>
       where T : Animal
    {
        // Realizuemo IComparer<T>
        public int Compare(T x, T y)
        {
            if (x.Weight > y.Weight)
                return 1;
            else if (x.Weight < y.Weight)
                return -1;
            else if (x.Weight == y.Weight)
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            else return 0;
        }
    }
}
