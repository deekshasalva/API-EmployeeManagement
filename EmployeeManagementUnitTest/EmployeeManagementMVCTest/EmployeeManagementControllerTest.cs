using EmployeeManagement.Controllers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagementUnitTest.EmployeeManagementMVCTest
{
    [TestFixture]
    public class EmployeeManagementControllerTest
    {
        private EmployeeController _employeeController;

        [SetUp]   //Arrange
        public void SetUp()
        {
            _employeeController = new EmployeeController();
            _employeeController.serviceObj = new FakeServiceRepository();
        }

        [Test]
        public void AddEmployee_ReturnsViewResult()
        {
            //Act
            var result =_employeeController.AddEmployee();

            //Assert
            Assert.That(result, Is.TypeOf<ViewResult>());
        }

        [Test]
        public void AddEmployee_PostMethod_ReturnsViewResult()
        {
            var result = _employeeController.AddEmployee();

            //Assert
            Assert.That(result, Is.TypeOf<ViewResult>());

        }

        [Test]
         public void GetAllEmployees_ReturnsViewResult()
         {
            var result = _employeeController.GetAllEmployees();
            Assert.That(result,Is.TypeOf<ViewResult>());
         }

        [Test]
        public void ChooseIdFor_GetEmployeeById_ReturnsViewResult()
        {
            int id = 6;
            var result = _employeeController.GetEmployee(id);
            Assert.That(result, Is.TypeOf<ViewResult>());
        }


        [Test]
        public void GetEmployeeById_ReturnsViewResult()
        {
            var result = _employeeController.GetEmployeeById();
            Assert.That(result, Is.TypeOf<ViewResult>());
        }



        [Test]
        public void DeletemployeeById_ReturnsViewResult()
        {
            int id = 20;
            var result = _employeeController.DeleteEmployee(id);
            Assert.That(result, Is.TypeOf<ViewResult>());
        }
    }
}


//TestMethod]
//        public void TestBookInsertion()
//{
//    //Arrange
//    BookStoreController controller = new BookStoreController();
//    //Act

//    ViewResult result = controller.BookInsertion() as ViewResult;
//    //Assert
//    Assert.IsNotNull(result);

//}
//[TestMethod]
//public void TestPostBookInsertion()
//{
//    BookStoreModel TestBook = new BookStoreModel();
//    //Arrange
//    BookStoreController controller = new BookStoreController();
//    TestBook.BookId = 111;
//    TestBook.BookTitle = "Ramayanaam";
//    TestBook.Category = "mythology";
//    TestBook.Author = "N Rai";
//    TestBook.Pages = 400;
//    TestBook.Tags = "ramayanbyrai";
//    TestBook.Location = "central";

//    //Act
//    ViewResult result = controller.BookInsertion(TestBook) as ViewResult;
//    //Assert
//    Assert.AreEqual("BOOK OF ID  " + TestBook.BookId + "  HAS BEEN SAVED SUCCESSFULLY", result.ViewBag.Msg);
//    Assert.IsNotNull(result);

//}
