using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OefenopdrachtPracticum1.Startup))]
namespace OefenopdrachtPracticum1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
