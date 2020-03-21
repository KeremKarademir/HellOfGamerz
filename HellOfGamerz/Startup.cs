using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HellOfGamerz.Startup))]
namespace HellOfGamerz
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
