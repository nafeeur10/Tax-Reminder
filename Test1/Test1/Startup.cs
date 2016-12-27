using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Test1.Startup))]
namespace Test1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
