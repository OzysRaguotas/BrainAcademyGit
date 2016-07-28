using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palyndrom
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get a word from console
            Console.WriteLine("Enter word");
            string word = Console.ReadLine();
            // Convert it into char array
            char[] Arr = word.ToCharArray();
            
            bool check = false;
            for (int i = 0; i < Arr.Length / 2; i++)
            {
                if (Arr[Arr.Length - 1 - i] == Arr[i])
                {
                    check = true;
                }
                else
                {
                    check = false;
                    Console.WriteLine("-");
                    Console.WriteLine("No, entered word is not a palyndrom");
                }
            }
            if (check == true)
                Console.WriteLine("Yes, entered word is palyndrom");
            Console.ReadLine();
        }
    }
}
