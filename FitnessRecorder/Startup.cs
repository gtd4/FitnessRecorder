using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FitnessRecorder.Startup))]
namespace FitnessRecorder
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
