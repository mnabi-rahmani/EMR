using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WardForms.Startup))]
namespace WardForms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
