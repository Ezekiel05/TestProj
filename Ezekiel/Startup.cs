using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ezekiel.Startup))]
namespace Ezekiel
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
