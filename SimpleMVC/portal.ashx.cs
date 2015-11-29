using SimpleMVC.Controllers;
using SimpleMVC.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC
{
    /// <summary>
    /// portal 的摘要说明
    /// </summary>
    public class Portal : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
          
            //首先拿到请求的URL-->Portal?m=xxx&c=xxx&a=xxx
           
            var controllerName = context.Request.QueryString["c"]??"home";
            IController controller = null;
            switch (controllerName.ToLower())
            {
                case "member":
                    controller = new MemberController();
                    break;
                case "product":
                    controller = new ProductController();
                    break;
            }
            if (controller == null)
            {
               throw new HttpException(404, "Not Found,I Want You");
            }
            else
            {
                controller.Execute(context);
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}