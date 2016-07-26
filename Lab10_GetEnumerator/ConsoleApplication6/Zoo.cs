using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_GetEnumerator
{
    public class Zoo : IEnumerable
    {
        private Animal[] animal = new Animal[6];
        public Zoo()
        {
            animal[0] = new Animal("Cat", "Amr", "Dark Grey", 8);
            animal[1] = new Animal("Cat", "Nes'ka", "Green Grey", 3);
            animal[2] = new Animal("Cat", "Bas`ka", "Three color", 5);
            animal[3] = new Animal("Dog", "Rada", "Dark yellow", 12);
            animal[4] = new Animal("Dog", "Gerta", "Rape yellow", 6);
            animal[5] = new Animal("Iguana", "Vugluskr", "Blue Green", 5);



        }
        public IEnumerator GetEnumerator()
        {
            foreach (Animal a in animal)
            {
                yield return a;
            }
        }
    }
}
