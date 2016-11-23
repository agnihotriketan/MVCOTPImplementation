using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OTPImplementation.Startup))]
namespace OTPImplementation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
