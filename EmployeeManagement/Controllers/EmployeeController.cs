using EmployeeManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult HomePage()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(Models.EmployeeModel employee)
        {
            ServiceRepository serviceObj = new ServiceRepository();
            HttpResponseMessage response = serviceObj.PostResponse("api/employeemanagement/addemployee", employee);
            response.EnsureSuccessStatusCode();
            return RedirectToAction("GetAllemployees");
        }

        public ActionResult GetAllEmployees()
        {
            try
            {
                ServiceRepository serviceObj = new ServiceRepository();
                HttpResponseMessage response = serviceObj.GetResponse("api/employeemanagement/getallemployees");
                response.EnsureSuccessStatusCode();
                List<Models.EmployeeModel> employeeModels = response.Content.ReadAsAsync<List<Models.EmployeeModel>>().Result;
                return View(employeeModels);
            }
            catch (Exception)
            {
                throw;
            }
        }


       
        public ActionResult GetEmployeeById()
        {
            try
            {
                ServiceRepository serviceObj = new ServiceRepository();
                HttpResponseMessage response = serviceObj.GetResponse("api/employeemanagement/getallemployees");
                response.EnsureSuccessStatusCode();
                List<Models.EmployeeModel> employeeModels = response.Content.ReadAsAsync<List<Models.EmployeeModel>>().Result;
                return View(employeeModels);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpGet]
        public ActionResult GetEmployee(int id)
        {
            ServiceRepository serviceObj = new ServiceRepository();
            HttpResponseMessage response = serviceObj.GetResponse("api/employeemanagement/getemployeebyid?id=" + id.ToString());
            response.EnsureSuccessStatusCode();
            Models.EmployeeModel employee = response.Content.ReadAsAsync<Models.EmployeeModel>().Result;
            return View(employee);
        }


        public ActionResult DeleteEmployee(int id)
        {
            ServiceRepository serviceObj = new ServiceRepository();
            HttpResponseMessage response = serviceObj.DeleteResponse("api/employeemanagement/deleteemployee?id=" + id.ToString());
            response.EnsureSuccessStatusCode();
            return RedirectToAction("GetAllEmployees");
        }

    }
}