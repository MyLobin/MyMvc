using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC.Routing
{
    public class RouteTable
    {
        /// <summary>
        /// globl route table
        /// </summary>
        public static IList<Route> Routes { get; set; }
        public RouteTable()
        {
            Routes = new List<Route>();
        }
        /// <summary>
        /// route object
        /// </summary>

    }
  
}