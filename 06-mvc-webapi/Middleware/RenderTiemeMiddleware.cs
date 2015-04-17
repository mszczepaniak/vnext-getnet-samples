using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace MvcWebApi06.MiddleWare
{
    public static class BuilderExtensions
    {
        public static IApplicationBuilder UseRenderTimeMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<RenderTimeMiddleware>();
        }
    }

    public class RenderTimeMiddleware
    {
        RequestDelegate _next;

        public RenderTimeMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            var sw = new Stopwatch();
            sw.Start();

            await _next(context);

            context.Response.Headers.Add("X-ElapsedTime", new[] { sw.ElapsedMilliseconds.ToString() });
        }
    }
}