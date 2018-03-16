using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lockbox.Startup))]
namespace Lockbox
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
