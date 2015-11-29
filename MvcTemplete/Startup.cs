using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcTemplete.Startup))]
namespace MvcTemplete
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
