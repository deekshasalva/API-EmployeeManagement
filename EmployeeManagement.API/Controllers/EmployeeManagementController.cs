using AutoMapper;
using EmployeeManagement.Object;
using EmployeeManagementDataAccess;
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
        public IEmployeeData _employeeData=new EmployeeData();
       
        //ModelMapping.ModelMapping modelMap=new ModelMapping.ModelMapping();

              

        [HttpGet]
        public JsonResult<List<EmployeeDataModel>> GetAllEmployees()
        {
            //List<Models.Employee> employees = new List<Models.Employee>();
            List<EmployeeDataModel> _Employees = _employeeData.GetAllEmployees();
            
            return Json(_Employees);
        }

        [HttpGet]
        public JsonResult<EmployeeDataModel> GetEmployeeById(int id)
        {
            EmployeeDataModel _Employees = _employeeData.GetEmployeeById(id);
            return Json(_Employees);

        }

        [HttpPost]
        public bool AddEmployee(EmployeeDataModel employee)
        {
            bool status = false;
            if (ModelState.IsValid)
            {
                status = _employeeData.AddEmployee(employee);
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
