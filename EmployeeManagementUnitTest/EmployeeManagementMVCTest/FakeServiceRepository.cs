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
        public HttpClient Client { get; set; }
        public FakeServiceRepository()
        {
            Client = new HttpClient();
            //string url = ConfigurationManager.AppSettings["ServiceUrl"].ToString();
            //Client.BaseAddress = new Uri(url);
            Client.BaseAddress = new Uri("http://localhost:55044/");
        }

        public HttpResponseMessage DeleteResponse(string url)
        {
            throw new NotImplementedException();
        }

        public HttpResponseMessage GetResponse(string url)
        {
            //    url = "http://google.com";
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
