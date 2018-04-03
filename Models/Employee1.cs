using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstApprochMVC.Models
{
    public class Employee1
    {
        [Key]
        public int empid { get; set; }

        public string empname { get; set; }

        public string address { get; set; }

        public Department department { get; set; }
    }
}