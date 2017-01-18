using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestForIFin.Startup))]
namespace TestForIFin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
