using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstApprochMVC.Models
{
    public class DataContext : DbContext
    {
        public DataContext(): base("conn")
        {

        }
        public DbSet<Employee1> Employees { get; set;  }
    }
}