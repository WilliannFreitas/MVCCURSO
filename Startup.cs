using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCCURSO.Startup))]
namespace MVCCURSO
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
