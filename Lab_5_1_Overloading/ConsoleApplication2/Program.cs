using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_1_Overloading
{
    class MyPoint
    {
        //Fields
        public int x, y, z;

        //Constructor
        public MyPoint(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        //Binary operator "+" overloading
        public static MyPoint operator -(MyPoint obj1, MyPoint obj2)
        {
            MyPoint coordinate = new MyPoint();
            coordinate.x = obj1.x - obj2.x;
            coordinate.y = obj1.y - obj2.y;
            coordinate.z = obj1.z - obj2.z;
            return coordinate;
        }
    }

    class Program
    {
        static void Main()
        {
            MyPoint point1 = new MyPoint(1, 2, 3);
            MyPoint point2 = new MyPoint(4, 5, 6);
            Console.WriteLine("First point coordinates: x: {0}, y: {1}, z: {2}", point1.x, point1.y, point1.z);
            Console.WriteLine("Second point coordinates: x: {0}, y: {1}, z: {2}", point2.x, point2.y, point2.z);

            MyPoint distanse = new MyPoint();
            distanse = point2 - point1;
            Console.WriteLine("Distanse between the points is equal: by x-axis: {0}, y-axis: {1}, z-axis: {2}", distanse.x, distanse.y, distanse.z);

            Console.ReadLine();


        }
    }
}
