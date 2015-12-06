using MyEF.Context;
using MyEF.Host;
using MyEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEF.Services
{
    public class ModelService:IModelService
    {
        public List<Employee> GetEmployeeList()
        {
            using (ModelContext context = new ModelContext("name=conn"))
            {
                return context.Employees.ToList();
            }
        }
        public int InsertEntity(Employee model)
        {
            using(ModelContext context=new ModelContext("conn"))
            {
                context.Employees.Add(model);
                return context.SaveChanges();
            }
        }
    }
}
