using Microsoft.AspNetCore.Http;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace REST_Api.Middleware
{
    public class CustomLoginMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomLoginMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task InvokeAsync(HttpContext context)
        {
            if(context.Request != null)
            {
                string path = context.Request.Path;
                string method = context.Request.Method;
                string queryString = context.Request.QueryString.ToString();
                string body = "";

                using(StreamReader reader = new StreamReader(context.Request.Body, Encoding.UTF8, true, 1024, true))
                {
                    body = await reader.ReadToEndAsync();
                }
            }

            if (_next != null)
            {
                await _next(context);
            }
        }
        
    }
}
