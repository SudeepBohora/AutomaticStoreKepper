using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomaticStoreKepper.Startup))]
namespace AutomaticStoreKepper
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
