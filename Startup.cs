using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(jc279115_MIS4200.Startup))]
namespace jc279115_MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
