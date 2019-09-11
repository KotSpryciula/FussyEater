using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FussyEater.Startup))]
namespace FussyEater
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
