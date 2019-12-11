using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DB
{
    public interface IEmployeeData
    {
        List<EmployeeDataModel> GetAllEmployees();
        EmployeeDataModel GetEmployeeById(int employeeId);
        bool AddEmployee(EmployeeDataModel _Employee);
        bool DeleteEmployee(int id);

    }
}
