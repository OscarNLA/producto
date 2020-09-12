using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ProductoEnum.Startup))]
namespace ProductoEnum
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
