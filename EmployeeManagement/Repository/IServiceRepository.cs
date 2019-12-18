using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Repository
{
    public interface IServiceRepository
    {
       
            HttpResponseMessage GetResponse(string url);
            HttpResponseMessage PutResponse(string url, object model);
            HttpResponseMessage PostResponse(string url, object model);
            HttpResponseMessage DeleteResponse(string url);
        
    }
}

