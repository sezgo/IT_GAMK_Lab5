using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IT_GAMK_Lab5.Startup))]
namespace IT_GAMK_Lab5
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
