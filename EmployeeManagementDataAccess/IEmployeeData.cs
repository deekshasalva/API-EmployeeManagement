using EmployeeManagement.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDataAccess
{
    public interface IEmployeeData
    {
        List<EmployeeDataModel> GetAllEmployees();
        EmployeeDataModel GetEmployeeById(int employeeId);
        bool AddEmployee(EmployeeDataModel _Employee);
        bool DeleteEmployee(int id);
    }
}
