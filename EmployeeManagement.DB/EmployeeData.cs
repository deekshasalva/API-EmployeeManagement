using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeeManagement.DB
{
    public class EmployeeData:IEmployeeData
    {
      
         EmployeeEntities employeeEntity = new EmployeeEntities();
        EntityMapper entityMapper = new EntityMapper();

        public  List<EmployeeDataModel> GetAllEmployees()
        {
            List<tbl_Employee> _Employee = new List<tbl_Employee>();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<List<tbl_Employee>,List<EmployeeDataModel>>());
            var map = config.CreateMapper();
            var data = map.Map<List<tbl_Employee>,List<EmployeeDataModel>>(_Employee);
            return data;
        }
        public EmployeeDataModel GetEmployeeById(int employeeId)
        {
            tbl_Employee employee= employeeEntity.tbl_Employee.Where(p => p.employeeId == employeeId).FirstOrDefault();
            var data = entityMapper.DBModelMappingGet(employee);
            return data;

        }
        public  bool AddEmployee(EmployeeDataModel _Employee)
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
       
        public  bool DeleteEmployee(int id)
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
