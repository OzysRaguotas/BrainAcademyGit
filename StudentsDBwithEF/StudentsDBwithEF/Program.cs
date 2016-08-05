using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDBwithEF
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("You work with Students-database");
                Console.WriteLine("Use next bottoms for action:");
                Console.WriteLine("1 - Add information for one student");
                Console.WriteLine("2 - Show students' list");
                Console.WriteLine("3 - Edit information by student's Name or student's ID");
                Console.WriteLine("4 - Remove information about chosen student by student's ID");
                Console.WriteLine("5 - Escape from the program");

                bool progrWork = true;
                while (progrWork == true)
                {
                    int action = Convert.ToInt32(Console.ReadLine());
                    switch (action)
                    {
                        case 1:
                            { dbOperations.AddInfo(); }
                            break;
                        case 2:
                            { dbOperations.ShowInfo(); }
                            break;
                        case 3:
                            { dbOperations.EditInfo(); }
                            break;
                        case 4:
                            { dbOperations.RemoveInfo(); }
                            break;
                        case 5:
                            { progrWork = true; }
                            break;
                    }
                }
            }
    }
}
