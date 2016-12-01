using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication2.Models;

namespace WebApplication2.DAL
{
    public class EmployeeInitializer: System.Data.Entity.DropCreateDatabaseIfModelChanges<EmployeeContext>
    {
        protected override void Seed(EmployeeContext context) {

            var employers = new List<EmployeeModel> {
            new EmployeeModel()
            {
                Id = 1001,
                Name = "Ivan",
                Department = "Sales"
            },
            new EmployeeModel()
            {
                Id = 1002,
                Name = "Vasily",
                Department = "Service center"
            },
            new EmployeeModel()
            {
                Id = 1003,
                Name = "Masha",
                Department = "Finance department"
            }};
            employers.ForEach(s => context.Employes.Add(s));
            context.SaveChanges();
        }
    }
}