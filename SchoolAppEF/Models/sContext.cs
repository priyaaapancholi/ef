using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolAppEF.Models
{
    public class sContext:DbContext
    {
        public DbSet<student> student { get; set; }
        public DbSet<course> course { set; get; }
    }
}