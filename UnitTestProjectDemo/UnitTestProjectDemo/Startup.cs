using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UnitTestProjectDemo.Startup))]
namespace UnitTestProjectDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
