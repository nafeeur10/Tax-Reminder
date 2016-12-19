using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tax_Reminder.Startup))]
namespace Tax_Reminder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
