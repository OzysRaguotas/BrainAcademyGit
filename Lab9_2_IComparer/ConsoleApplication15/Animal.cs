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
}
