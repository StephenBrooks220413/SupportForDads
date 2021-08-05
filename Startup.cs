using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SupportForDads.Startup))]
namespace SupportForDads
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
