using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homework_3.Startup))]
namespace Homework_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
