using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Models
{
    public class EmployeeModel
    {
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public int Age { get; set; }
        public double salaryInLakh { get; set; }
    }
}