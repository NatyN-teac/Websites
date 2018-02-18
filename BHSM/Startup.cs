using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BHSM.Startup))]
namespace BHSM
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
