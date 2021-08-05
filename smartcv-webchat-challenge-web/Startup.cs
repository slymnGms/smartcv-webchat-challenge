using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(smartcv_webchat_challenge.Startup))]
namespace smartcv_webchat_challenge
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}