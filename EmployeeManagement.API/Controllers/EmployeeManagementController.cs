using AutoMapper;
using EmployeeManagement.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;


namespace EmployeeManagement.API.Controllers
{
    public class EmployeeManagementController : ApiController
    {
        private readonly IEmployeeData _employeeData;
       
        ModelMapping.ModelMapping modelMap=new ModelMapping.ModelMapping();

        public EmployeeManagementController(IEmployeeData employeeData)
        {
            _employeeData = employeeData;
        }
        

        [HttpGet]
        public JsonResult<List<EmployeeDataModel>> GetAllEmployees()
        {
            List<EmployeeDataModel> _Employees = _employeeData.GetAllEmployees().ToList();
            return Json(_Employees);
        }

        [HttpGet]
        public JsonResult<Models.Employee> GetEmployeeById(int id)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_Employee, Models.Employee>());
            var map = config.CreateMapper();
            EmployeeDataModel _Employees = _employeeData.GetEmployeeById(id);
            var data = modelMap.ApiModelMappingGet(_Employees);
            return Json(data);

        }

        [HttpPost]
        public bool AddEmployee(Models.Employee employee)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                var data = modelMap.ApiModelMappingPost(employee);
                status = _employeeData.AddEmployee(data);
                return status;

            }
            return status;
        }

        [HttpDelete]
        public bool DeleteEmployee(int id) //this is a simple object so u can use like /api/values/deleteemployye?id=
        {
            var status = _employeeData.DeleteEmployee(id);
            return status;
        }
    }
}
