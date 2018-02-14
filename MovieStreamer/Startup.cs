using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MovieStreamer.Startup))]
namespace MovieStreamer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
