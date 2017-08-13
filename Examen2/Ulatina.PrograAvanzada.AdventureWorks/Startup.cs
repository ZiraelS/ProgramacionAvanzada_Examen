using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Ulatina.PrograAvanzada.AdventureWorks.Startup))]
namespace Ulatina.PrograAvanzada.AdventureWorks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
