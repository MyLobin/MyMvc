using MyEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyEF.Host
{
    [ServiceContract]
  public  interface IModelService
    {
        [OperationContract]
        List<Employee> GetEmployeeList();
    }
}
