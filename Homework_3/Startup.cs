using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeWork_3.Startup))]
namespace HomeWork_3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
