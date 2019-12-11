using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.DB
{
    public class EntityMapper
    {
        public EmployeeDataModel DBModelMappingGet(tbl_Employee employee)
        {
            try
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<tbl_Employee,EmployeeDataModel>());
                var map = config.CreateMapper();
                var data = map.Map<tbl_Employee,EmployeeDataModel>(employee);
                return data;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public tbl_Employee DBModelMappingPost(EmployeeDataModel employee)
        {
            try
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<EmployeeDataModel,tbl_Employee>());
                var map = config.CreateMapper();
                var data = map.Map<EmployeeDataModel,tbl_Employee>(employee);
                return data;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
