using EmployeeManagement.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementDataAccess
{
    public class EmployeeData:IEmployeeData
    {
        EmployeeEntities employeeEntity = new EmployeeEntities();
        EntityMapper entityMapper = new EntityMapper();

        public List<EmployeeDataModel> GetAllEmployees()
        {
            List<tbl_Employee> employee = employeeEntity.tbl_Employee.ToList();
            List<EmployeeDataModel> employeeData = new List<EmployeeDataModel>();
            foreach (tbl_Employee _Employee in employee)
            {
                var data = entityMapper.DBModelMappingGet(_Employee);
                employeeData.Add(data);
            }
            return employeeData;
        }

        public EmployeeDataModel GetEmployeeById(int employeeId)
        {
            tbl_Employee employee = employeeEntity.tbl_Employee.Where(p => p.employeeId == employeeId).FirstOrDefault();
            var data = entityMapper.DBModelMappingGet(employee);
            return data;

        }

        public bool AddEmployee(EmployeeDataModel _Employee)
        {
            var data = entityMapper.DBModelMappingPost(_Employee);
            bool status;
            try
            {
                employeeEntity.tbl_Employee.Add(data);
                employeeEntity.SaveChanges();
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

        public bool DeleteEmployee(int id)
        {
            bool status;
            try
            {
                tbl_Employee employeeToDelete = employeeEntity.tbl_Employee.Where(p => p.employeeId == id).FirstOrDefault();
                if (employeeToDelete != null)
                {
                    employeeEntity.tbl_Employee.Remove(employeeToDelete);
                    employeeEntity.SaveChanges();
                }
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            return status;
        }

    }
}

