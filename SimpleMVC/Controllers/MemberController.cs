using SimpleMVC.MVC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC.Controllers
{
    public class MemberController:IController
    {
        #region IController 成员
        HttpContext context = null;
        public void Execute(HttpContext context)
        {
            this.context=context;
            var action = context.Request.QueryString["a"] ?? "index";
            switch (action.ToLower())
            {
                case "index":
                    Index();
                    break;
            }
            if (this.context == null)
            {
                throw new HttpException(404, "Not Action");
            }
        }
        public void Index()
        {
            context.Response.Write("member index action");
        }

        #endregion
    }
}