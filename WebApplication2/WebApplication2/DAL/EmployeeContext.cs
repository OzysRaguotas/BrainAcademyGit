using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication2.DAL
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext() : base("EmployeeContext")
        {
        }

        public DbSet<EmployeeModel> Employes { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}