using MyEF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            //ModelService service = new ModelService();
            //var list=service.GetEmployeeList();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.FirstName);
            //}
            ServiceReference1.ModelServiceClient client = new ServiceReference1.ModelServiceClient();
            var list=client.GetEmployeeList();

            Console.ReadKey();
        }
    }
}
