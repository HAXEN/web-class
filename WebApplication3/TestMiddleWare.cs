using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebApplication3
{
    public class TestMiddleWare
    {
        private readonly RequestDelegate _next;

        public TestMiddleWare(RequestDelegate next)
        {
            _next = next;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            context.Items["Killroy"] = "was here";
            await _next.Invoke(context);
        }
    }
}