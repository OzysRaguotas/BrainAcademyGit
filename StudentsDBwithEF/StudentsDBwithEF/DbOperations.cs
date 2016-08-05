using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace StudentsDBwithEF
{
    public class dbOperations
    {
        private static readonly StudentContext db = new StudentContext();

        public static void AddInfo()
        {
            Console.WriteLine("Enter name");
            var name = Console.ReadLine();
            Console.WriteLine("Enter group");
            var group = Console.ReadLine();
            Console.WriteLine("Enter student's ID");
            var id = Console.ReadLine();
            Console.WriteLine("Enter average rate");
            var s = Console.ReadLine();
            var AvR = Convert.ToDouble(s);
            Student student = new Student
            {
                Name = name,
                Group = group,
                StudID= id,
                AvgRate = AvR
            };
            db.Students.Add(student);
            db.SaveChanges();
            Console.WriteLine("Student's information is successfully added");
        }
     public static void ShowInfo()
        {
            var students = db.Students;
            foreach (var student in students)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", student.ID, student.Name, student.Group, student.StudID, student.AvgRate);
            }
        }
     public static void EditInfo()
        {
            Console.WriteLine("For edit student information by Name enter 1, by ID enter 2");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("Enter student's Name");
                var n = Console.ReadLine();
                Student sst = (from s in db.Students
                                 where s.Name == n
                                 select s).Single<Student>();
                Console.WriteLine("Enter name");
                sst.Name = Console.ReadLine();
                Console.WriteLine("Enter group");
                sst.Group = Console.ReadLine();
                Console.WriteLine("Enter student's ID");
                sst.StudID = Console.ReadLine();
                Console.WriteLine("Enter average rate");
                sst.AvgRate = Convert.ToDouble(Console.ReadLine());
                db.SaveChanges();
            }
            else if (choose == 2)
            {
                Console.WriteLine("Enter student's ID");
                var StudID = Convert.ToInt32(Console.ReadLine());
                Student student = db.Students.Find(StudID);
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", student.ID, student.Name, student.Group, student.StudID, student.AvgRate);
                Console.WriteLine("Enter name");
                student.Name = Console.ReadLine();
                Console.WriteLine("Enter group");
                student.Group = Console.ReadLine();
                Console.WriteLine("Enter student's ID");
                student.StudID = Console.ReadLine();
                Console.WriteLine("Enter average rate");
                student.AvgRate = Convert.ToDouble(Console.ReadLine());
                db.SaveChanges();
            }
        }
     public static void RemoveInfo()
        {
            Console.WriteLine("For choose student by Name enter 1, by ID enter 2");
            int choose = Convert.ToInt32(Console.ReadLine());
            if (choose == 1)
            {
                Console.WriteLine("Enter student's Name");
                var n = Console.ReadLine();
                Student sst = (from s in db.Students
                               where s.Name == n
                               select s).Single<Student>();
                db.Students.Remove(sst);
                db.SaveChanges();
            }
            else  if (choose == 2)
            {
                Console.WriteLine("Enter student's ID");
                var id = Console.ReadLine();
                Student student = db.Students.Find(id);
                db.Students.Remove(student);
                db.SaveChanges();
            }
        }
    }
}
