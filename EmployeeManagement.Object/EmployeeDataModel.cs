using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Object
{
    public class EmployeeDataModel
    {
        public int employeeId { get; set; }
        [Required, MinLength(3)]
        public string employeeName { get; set; }
        public int Age { get; set; }
        public double salaryInLakh { get; set; }
    }
}
