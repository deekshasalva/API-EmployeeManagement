using EmployeeManagement.Object;
using EmployeeManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace EmployeeManagementUnitTest.EmployeeManagementMVCTest
{
    public class FakeServiceRepository:IServiceRepository
    {
        
        public HttpResponseMessage DeleteResponse(string url)
        {
            throw new NotImplementedException();
        }
        
        public HttpResponseMessage GetResponse(string url)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage PostResponse(string url, object model)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage PutResponse(string url, object model)
        {
            throw new NotImplementedException();
        }
    }
}
