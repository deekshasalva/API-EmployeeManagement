using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using EmployeeManagement.DB;

namespace EmployeeManagement.API.ModelMapping
{
    public class ModelMapping
    {
        public Models.Employee ApiModelMappingGet(EmployeeDataModel employee)
        {
            try
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<EmployeeDataModel, Models.Employee>());
                var map = config.CreateMapper();
                var data = map.Map<EmployeeDataModel, Models.Employee>(employee);
                return data;

            }
            catch(Exception)
            {
                throw;
            }
        }

        public EmployeeDataModel ApiModelMappingPost(Models.Employee employee)
        {
            try
            {
                var config = new MapperConfiguration(cfg => cfg.CreateMap<Models.Employee, EmployeeDataModel>());
                var map = config.CreateMapper();
                var data = map.Map<Models.Employee, EmployeeDataModel>(employee);
                return data;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}