using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SodingAssignment.Startup))]
namespace SodingAssignment
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
