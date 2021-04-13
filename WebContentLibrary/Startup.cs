using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebContentLibrary.Startup))]
namespace WebContentLibrary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
