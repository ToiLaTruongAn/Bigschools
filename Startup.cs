using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bigschools.Startup))]
namespace Bigschools
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
