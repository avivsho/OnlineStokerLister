using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineStokerLister.Startup))]
namespace OnlineStokerLister
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
