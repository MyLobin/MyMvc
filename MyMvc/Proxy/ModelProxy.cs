using MyEF.Host;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace MyMvc.Proxy
{
    public class ModelProxy
    {

        public static IModelService CreateService()
        {
            //return this.CreateService<IModelService>(serviceUri);
            ChannelFactory<IModelService> chan = new ChannelFactory<IModelService>("modelService");
            return chan.CreateChannel();
           
        }

    

    }
}