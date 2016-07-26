using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_GetEnumerator
{
    public class Animal
    {
        public string Specie { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Age { get; set; }
        public Animal(string sp, string nm, string col, int age)
        {
            Specie = sp;
            Name = nm;
            Color = col;
            Age = age;
        }
    }
}
