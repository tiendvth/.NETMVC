using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using T2009015_DANGVANTIEN.Models;

namespace T2009015MVC.Data
{
    public class MyDbContext: DbContext
    {
        public MyDbContext(): base("name = MyDbContext")
        {

        }
        public DbSet<Student> MyStdudentDbSet { get;set }
    }
}