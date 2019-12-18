using EmployeeManagement.Object;
using EmployeeManagementDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementUnitTest.EmployeeManagementAPITest
{
    public class FakeEmployeeData : IEmployeeData
    {
        public bool AddEmployee(EmployeeDataModel _Employee)
        {
            return true;
        }

        public bool DeleteEmployee(int id)
        {
            if (id == 2)
            {
                return false;
            }
            else return true;
        }

        public List<EmployeeDataModel> GetAllEmployees()
        {
            List<EmployeeDataModel> employeeDatas = new List<EmployeeDataModel>() {
             new EmployeeDataModel()
             {
                employeeName="ananya",
                Age=21,
                salaryInLakh=9.6
                 
             }

            };
            return employeeDatas;
        }

        public EmployeeDataModel GetEmployeeById(int employeeId)
        {
            if(employeeId==56)
            {
                return null;
            }
            else
            {
                EmployeeDataModel employee = new EmployeeDataModel();
                employee.employeeName = "sana";
                employee.Age = 45;
                employee.salaryInLakh = 9.78;
                return employee;
            }
        }
    }
}
