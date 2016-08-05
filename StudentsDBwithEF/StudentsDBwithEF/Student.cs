using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsDBwithEF
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Group { get; set; }
        public string StudID { get; set; }
        public double AvgRate { get; set; }
    }
}
