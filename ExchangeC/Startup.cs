using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExchangeC.Startup))]
namespace ExchangeC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
