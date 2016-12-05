using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Homework_1.Startup))]
namespace Homework_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
