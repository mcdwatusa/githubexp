using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(githubtest.Startup))]
namespace githubtest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
