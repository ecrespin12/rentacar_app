using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebRentaCar.Startup))]
namespace WebRentaCar
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
