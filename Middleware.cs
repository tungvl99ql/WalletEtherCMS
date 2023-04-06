using Microsoft.AspNetCore.Http;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Mid
{
    public class Middleware
    {
        private readonly RequestDelegate _next;
        public Middleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            var requestPath = httpContext.Request.Path.ToString();
            if (requestPath == "/Auth" || requestPath == "/Auth/Login" || requestPath == "/Auth/Register" || requestPath == "/Auth/postRegister" || requestPath.Contains("Api")) //  vào controller login
            {
                await _next(httpContext);
            }
            else //  controller khác
            {
                var Token = httpContext.Session.GetString("Token");
                var Endtoken =  httpContext.Session.GetString("EndToken");
                if ( (Endtoken != null && DateTime.Now >= DateTime.Parse(Endtoken)) || Token == null || Token == "")
                {
                    await Task.Run(() =>
                    {
                        httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                        httpContext.Response.Redirect("Auth");
                    });
                    return;
                }

               
                //if (Token == null || Token == "" )
                //{
                //    await Task.Run(() =>
                //           {
                //               httpContext.Response.StatusCode = StatusCodes.Status401Unauthorized;
                //               httpContext.Response.Redirect("Auth");
                //           });
                //    return;
                //}
                await _next(httpContext);
            }
        }
    }
}
