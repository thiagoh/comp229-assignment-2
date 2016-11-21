using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(comp229_assignment_2.Startup))]
namespace comp229_assignment_2 {
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
