using CodeFirstApprochMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstApprochMVC
{
    public class Department
    {
        public int DepartmenId { get; set; }
        public string department { get; set; }
        public ICollection<Employee1> Employees { get; set; }
    }
}