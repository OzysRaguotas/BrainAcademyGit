using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestForIFin.Models;
using System.Data.Entity;

namespace TestForIFin.DAL
{
    public class EmployeeInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context)
        {
            var employees = new List<Employee>
            {
                new Employee{ FirstName="Ostap",LastName="Bender"},
                new Employee { FirstName = "Zitz-predsedatel", LastName = "Funt", BossId = 0},
                new Employee { FirstName = "Shura", LastName = "Balaganov", BossId = 0},
                new Employee { FirstName = "Adam", LastName = "Kozlevich", BossId = 0},
                new Employee { FirstName = "Mikhail", LastName = "Panikovskiy", BossId = 2}
            };
            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}