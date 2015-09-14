using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eRestaurant_Demo.Startup))]
namespace eRestaurant_Demo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
