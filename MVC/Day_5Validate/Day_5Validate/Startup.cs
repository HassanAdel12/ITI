using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Day_5Validate.Startup))]
namespace Day_5Validate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
