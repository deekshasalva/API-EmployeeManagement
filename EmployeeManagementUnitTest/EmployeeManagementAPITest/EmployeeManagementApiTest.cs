using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;
using EmployeeManagement.API.Controllers;
using EmployeeManagement.Object;
using System.Web.Http;
using System.Web.Http.Results;

namespace EmployeeManagementUnitTest.EmployeeManagementAPITest
{
    /// <summary>
    /// Summary description for EmployeeManagementApiTest
    /// </summary>
    [TestFixture]
    public class EmployeeManagementApiTest
    {
        private EmployeeManagementController _employeeController;
        [SetUp]   //Arrange
        public void SetUp()
        {
            _employeeController = new EmployeeManagementController();
            _employeeController._employeeData = new FakeEmployeeData();
        }

        [Test]
        public void AddEmployee_ModelInvalid_ReturnsFalse()
        {
            //Arrange
            var employee = new EmployeeDataModel();
            _employeeController.ModelState.AddModelError("error","error");

            //Act
            var result = _employeeController.AddEmployee(employee);

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void AddEmployee_ModelValid_ReturnsTrue()
        {
            //Arrange
            var employee = new EmployeeDataModel { employeeName="geeta", Age=21,salaryInLakh=3.7};

            //Act
            var result = _employeeController.AddEmployee(employee);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void GetAllEmployees_ModelValid_ReturnsTrue()
        {
            //Arrange

            //Act
            var result = _employeeController.GetAllEmployees();

            //Assert
            Assert.That(result,Is.TypeOf<JsonResult<List<EmployeeDataModel>>>());
        }

        [Test]
        public void GetEmployee_ById_ReturnsFalse()
        {
            int id = 56;
            var result = _employeeController.GetEmployeeById(id);
            Assert.That(result, Is.TypeOf < JsonResult<EmployeeDataModel>>());

        }

        [Test]
        public void GetEmployee_ById_ReturnsTrue()
        {
            int id = 2;
            var result = _employeeController.GetEmployeeById(id);
            Assert.That(result, Is.TypeOf<JsonResult<EmployeeDataModel>>());

        }

        [Test]
        public void DeleteEmployee_ById_ReturnsFalse()
        {
            int id = 2;
            var result = _employeeController.DeleteEmployee(id);
            Assert.IsFalse(result);
        }

        [Test]
        public void DeleteEmployee_ById_ReturnsTrue()
        {
            int id = 12;
            var result = _employeeController.DeleteEmployee(id);
            Assert.IsTrue(result);
        }
    }
}
