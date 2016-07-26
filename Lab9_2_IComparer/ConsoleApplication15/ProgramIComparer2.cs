using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Animal
    {
        public byte Weight;
        public string Specie;
        public int MaxSpeed;

        public Animal()
        { }
        public Animal(byte Weight, string Specie, int MaxSpeed)
        {
            this.Weight = Weight;
            this.Specie = Specie;
            this.MaxSpeed = MaxSpeed;
        }

        public override string ToString()
        {
            return String.Format("\tVyd: {0}, \tVaga: {1}, \tMaxymalna shvydkist: {2}", this.Specie, this.Weight, this.MaxSpeed);
        }

    }
    class WeightDescending<T> : IComparer<T>
        where T : Animal
    {
        // Realizuemo IComparer<T>
        public int Compare(T x, T y)
        {
            if (x.Weight < y.Weight)
                return 1;
            if (x.Weight > y.Weight)
                return -1;
            else return 0;
        }
    }

    class WeightAscending<T> : IComparer<T>
       where T : Animal
    {
        // Realizuemo IComparer<T>
        public int Compare(T x, T y)
        {
            if (x.Weight > y.Weight)
                return 1;
            if (x.Weight < y.Weight)
                return -1;
            else return 0;
        }
    }

    class SpeedDescending<T> : IComparer<T>
    where T : Animal
    {
        // Realizuemo IComparer<T>
        public int Compare(T x, T y)
        {
            if (x.MaxSpeed < y.MaxSpeed)
                return 1;
            if (x.MaxSpeed > y.MaxSpeed)
                return -1;
            else return 0;
        }
    }

    class SpeedAscending<T> : IComparer<T>
       where T : Animal
    {
        // Realizuemo IComparer<T>
        public int Compare(T x, T y)
        {
            if (x.MaxSpeed > y.MaxSpeed)
                return 1;
            if (x.MaxSpeed < y.MaxSpeed)
                return -1;
            else return 0;
        }
    }
    class SpecieDescending : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            return x.Specie.CompareTo(y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WeightDescending<Animal> wd = new WeightDescending<Animal>();
            SpeedDescending<Animal> sd = new SpeedDescending<Animal>();
            WeightAscending<Animal> wa = new WeightAscending<Animal>();
            SpeedAscending<Animal> sa = new SpeedAscending<Animal>();
            List<Animal> dic = new List<Animal>();
            dic.Add(new Animal(5, "Felis Domestic", 50));
            dic.Add(new Animal(20, "Canis Canis", 65));
            dic.Add(new Animal(50, "Capra Hircus", 35));


            Console.WriteLine("Vyhidnyi nabir tvaryn");
            foreach (Animal a in dic)
                Console.WriteLine(a);

            Console.WriteLine("\nTeper tvaryny sortyrovani po spadanny vagi: \n");
            dic.Sort(wd);
            foreach (Animal a in dic)
            Console.WriteLine(a);

            Console.WriteLine("\nTeper tvaryny sortyrovani po zrostanny vagi: \n");
            dic.Sort(wa);
            foreach (Animal a in dic)
                Console.WriteLine(a);

            Console.WriteLine("\nTeper tvaryny sortyrovani po spadanny shvydkosti: \n");
            dic.Sort(sd);
            foreach (Animal a in dic)
                Console.WriteLine(a);

            Console.WriteLine("\nTeper tvaryny sortyrovani po zrostanny shvydkosti: \n");
            dic.Sort(sa);
            foreach (Animal a in dic)
                Console.WriteLine(a);
            Console.ReadLine();

        }
    }
}
