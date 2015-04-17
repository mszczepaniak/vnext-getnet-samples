using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.Runtime;

namespace VerA
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app, IRuntimeEnvironment runtime)
        {
            var rtm = "ver: {0}, arch: {1}, type: {2}";
            rtm = string.Format(rtm, runtime.RuntimeVersion, runtime.RuntimeArchitecture, runtime.RuntimeType);

            app.Run(async ctx => {
                ctx.Response.ContentType = "text/plain";
                ctx.Response.StatusCode = 200;

                await ctx.Response.WriteAsync(rtm);
            });
        }
    }
}