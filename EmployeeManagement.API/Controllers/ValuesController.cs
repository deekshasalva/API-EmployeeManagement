using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using EmployeeManagement.DB;
using AutoMapper;

namespace EmployeeManagement.API.Controllers
{
    public class ValuesController : ApiController
    {
        EmployeeData employeeData = new EmployeeData();

        [HttpGet]
        public JsonResult<List<tbl_Employee>> GetAllEmployees()
        {
            List<tbl_Employee> _Employees = employeeData.GetAllEmployees();
            return Json(_Employees);
        }

        [HttpGet]
        public JsonResult<Models.Employee> GetEmployeeById(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_Employee,Models.Employee>());
            var map = config.CreateMapper();
            tbl_Employee _Employees = employeeData.GetEmployeeById(id);
            Models.Employee employee = new Models.Employee();
            var data = map.Map<tbl_Employee, Models.Employee>(_Employees);
             return Json(data);
           
        }

        [HttpPost]
        public bool AddEmployee(Models.Employee employee) 
        {
            bool status = false;
            if(ModelState.IsValid)
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.Employee,tbl_Employee>());
                var map = config.CreateMapper();
                var data = map.Map<Models.Employee,tbl_Employee > (employee);
                status = employeeData.AddEmployee(data);
                return status;

            }
            return status;
        }
      
        [HttpDelete]
        public bool DeleteEmployee(int id) //this is a simple object so u can use like /api/values/deleteemployye?id=
        {
            var status = employeeData.DeleteEmployee(id);
            return status;
        }
    }
}

