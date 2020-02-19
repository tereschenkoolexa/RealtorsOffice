using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RealtorsOffice.Startup))]
namespace RealtorsOffice
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
