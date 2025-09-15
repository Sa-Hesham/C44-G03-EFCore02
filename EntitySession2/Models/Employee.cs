using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitySession2.Models
{

    internal class Employee
    {
        public int EmpId { get; set; }
        public string? EmpName { get; set; }

        public decimal Salary { get; set; }


        public int Age { get; set; }
    }
}
