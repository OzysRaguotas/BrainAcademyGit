using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class SpecieCompare : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            return x.Specie.CompareTo(y);
        }
    }
}
