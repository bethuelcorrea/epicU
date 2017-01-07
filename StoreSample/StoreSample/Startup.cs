using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StoreSample.Startup))]
namespace StoreSample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
