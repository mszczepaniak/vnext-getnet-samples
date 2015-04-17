using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Diagnostics;
using Microsoft.AspNet.StaticFiles;

namespace Staticfiles06
{
    public class Startup
    {   
        public void Configure(IApplicationBuilder app)
        {
            app.UseStaticFiles();
            app.UseWelcomePage();
        }
    }
}
