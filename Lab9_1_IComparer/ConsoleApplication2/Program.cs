using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   class Animal: IComparable<Animal>
        { // Fields
        byte Weight;
        string Specie;
        int MaxSpeed;

        //public Animal() Constructor
        public Animal(byte Weight, string Specie, int MaxSpeed)
        {
            this.Weight = Weight;
            this.Specie = Specie;
            this.MaxSpeed = MaxSpeed;
        }

        // Realize interface IComparable
        public int CompareTo(Animal obj)
        {
            if (this.MaxSpeed > obj.MaxSpeed)
                return 1;
            if (this.MaxSpeed < obj.MaxSpeed)
                return -1;
            else
                return 0;
        }
        public override string ToString()
        {
            return String.Format("\tVyd: {0}, \tVaga: {1}, \tMaxymalna shvydkist: {2}", this.Specie, this.Weight, this.MaxSpeed);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Create List<> of class Animal objects
            List<Animal> dic = new List<Animal>();
            dic.Add(new Animal(5, "Felis Domestic", 50));
            dic.Add(new Animal(20, "Canis Canis", 65));
            dic.Add(new Animal(50, "Capra Hircus", 35));


            Console.WriteLine("Vyhidnyi nabir tvaryn");
            foreach (Animal a in dic)
                Console.WriteLine(a);

            // Realize Sort<> for List<Animal>
            Console.WriteLine("\nTeper tvaryny sortyrovani po shvydkosti: \n");
            dic.Sort();
            foreach (Animal a in dic)
                Console.WriteLine(a);

            Console.ReadLine();
        }   
    }
}
