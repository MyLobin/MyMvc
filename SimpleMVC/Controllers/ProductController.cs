using SimpleMVC.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC.Controllers
{
    public class ProductController:IController
    {
        #region IController 成员

        public void Execute(HttpContext context)
        {
            context.Response.Write("product");
        }

        #endregion
    }
}