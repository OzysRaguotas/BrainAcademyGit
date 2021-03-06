﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace StudentsDBwithEF
{
    class StudentContext: DbContext
    {
        public StudentContext()
             : base("DbConnection")
        { }
        public DbSet<Student> Students { get; set; }
    }
}
