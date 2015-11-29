using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC.Routing
{
    public class Route
    {
        public Route(string url, object defaults)
        {
            UrlTemplate = url;
            Defaults = new Dictionary<string, object>();
            var defProps = defaults.GetType().GetProperties();
            foreach (var item in defProps)
            {
                Defaults.Add(item.Name, item.GetValue(defaults));
            }
        }
        public string UrlTemplate { get; set; }
        /// <summary>
        /// new{controller="Home"
        /// </summary>
        public IDictionary<string, object> Defaults { get; set; }

        internal void MatchUrl(string requestUrl)
        {
            throw new NotImplementedException();
        }
    }
}