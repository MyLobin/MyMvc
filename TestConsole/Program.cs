using MyEF.Host;
using MyEF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
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
            ///Additional information: 在 ServiceModel 客户端配置部分中，找不到名称“getEmployeeList”和协定“TestConsole.IModelService”的终结点元素。这可能是因为未找到应用程序的配置文件，或者是因为客户端元素中找不到与此名称匹配的终结点元素。
            var proxy = new ChannelFactory<IModelService>("getEmployeeList");
            var list = proxy.CreateChannel().GetEmployeeList();
            Console.ReadKey();
        }
    }
}
