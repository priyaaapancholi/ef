using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SchoolAppEF.Startup))]
namespace SchoolAppEF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
