using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarCard.Startup))]
namespace CarCard
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
