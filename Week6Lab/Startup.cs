using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Week6Lab.Startup))]
namespace Week6Lab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
