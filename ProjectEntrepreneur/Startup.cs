using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProjectEntrepreneur.Startup))]
namespace ProjectEntrepreneur
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
