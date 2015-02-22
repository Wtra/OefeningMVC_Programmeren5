using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OefeningMVC_Programmeren5.Startup))]
namespace OefeningMVC_Programmeren5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
