using EmployeeManagement.Object;
using EmployeeManagementDataAccess;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace EmployeeManagementUnitTest.EmployeeManagementDataAccessTest
{
    public class EmployeeDataTest
    {
        

        [Test]
        public void AddEmployees_IfValid_ReturnsTrue()
        {
            ////create fake object
            //var dataAccessObject = new Mock<IEmployeeData>();
            var employee = new EmployeeDataModel();
            employee.employeeName = "Paras";
            employee.Age = 23;
            employee.salaryInLakh = 7.5;
            ////Set the Mock Configuration
            ////The CheckDeptExist() method is call is set with the Integer parameter type
            ////The Configuration also defines the Return type from the method  
            //dataAccessObject.Setup(obj => obj.AddEmployee(It.IsAny<EmployeeDataModel>())).Returns(true);

            ////call the method
            //var result =dataAccessObject.Object.AddEmployee(employee);

            //Assert.IsTrue(result);

            EmployeeData employeeData = new EmployeeData();
            var result = employeeData.AddEmployee(employee);
            Assert.IsTrue(result);
        }

        [Test]
        public void GetAllEmployees_IfPresent_ReturnList()
        {
            EmployeeData employeeData = new EmployeeData();
            var result = employeeData.GetAllEmployees();
            Assert.That(result, Is.TypeOf<List<EmployeeDataModel>>());
        }

        [Test]
        public void GetEmployeeById_IfPresent_ReturnModel()
        {
            int id = 6;
            EmployeeData employeeData = new EmployeeData();
            var result = employeeData.GetEmployeeById(id);
            Assert.That(result, Is.TypeOf<EmployeeDataModel>());
        }

        [Test]
        public void DeleteEmployeeById_IfNotPresent_ReturnFalse()
        {
            int id = 100;
            EmployeeData employeeData = new EmployeeData();
            var result = employeeData.DeleteEmployee(id);
            Assert.IsFalse(result);
        }
        [Test]
        public void DeleteEmployeeById_IfPresent_ReturnTrue()
        {
            int id = 17;
            EmployeeData employeeData = new EmployeeData();
            var result = employeeData.DeleteEmployee(id);
            Assert.IsTrue(result);
        }





    }
}
