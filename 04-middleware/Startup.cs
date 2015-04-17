using System;
// IApplicationBuilder
using Microsoft.AspNet.Builder; 
// context
using Microsoft.AspNet.Http;
// user error page
using Microsoft.AspNet.Diagnostics;

public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        app.Use(async (ctx, next) =>
        {
            var from = ctx.Request.Headers["from"];
            if(from == "kuba@gutek.pl") {
                ctx.Response.StatusCode = 403;
                ctx.Response.ContentType = "text/html";
                await ctx.Response.WriteAsync("<h1>Don't bother, it will not work on your computer Gutek!!!</h1>");
            }
            else if(from == "gutek@gutek.pl") 
            {
                ctx.Response.StatusCode = 403;
                throw new Exception("Told ya!, it will not work for you, just give up");
            }
            else 
            {
                await next();
            }
        });
 
        app.UseErrorPage(ErrorPageOptions.ShowAll);

        app.Run(async ctx =>
        {
            ctx.Response.StatusCode = 200;
            ctx.Response.ContentType = "text/html";
            await ctx.Response.WriteAsync("<h1>Hello, GET.NET!</h1>");
        });
    }
}