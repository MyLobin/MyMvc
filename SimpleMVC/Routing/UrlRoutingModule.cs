using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC.Routing
{
    public class UrlRoutingModule:IHttpModule
    {
        #region IHttpModule 成员

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void Init(HttpApplication application)
        {
            application.PostResolveRequestCache += application_PostResolveRequestCache;
        }

        void application_PostResolveRequestCache(object sender, EventArgs e)
        {
            var applicatin = sender as HttpApplication;
            var context = applicatin.Context;

            var requestUrl = context.Request.AppRelativeCurrentExecutionFilePath.Substring(2);
            foreach (Route route in RouteTable.Routes)
            {
                route.MatchUrl(requestUrl);
            }
        }

        #endregion
    }
}