using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SignalR_Client_Http.Startup))]
namespace SignalR_Client_Http
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //;ConfigureAuth(app);
        }
    }
}
