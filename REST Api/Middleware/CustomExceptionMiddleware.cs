using Microsoft.AspNetCore.Http;
using REST_Api.Exceptions;
using REST_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;

namespace REST_Api.Middleware
{
    public class CustomExceptionMiddleware
    {
        public readonly RequestDelegate _next;

        public CustomExceptionMiddleware(RequestDelegate next) 
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            } catch(Exception ex)
            {
                await HandleException(context, ex);
            }
        }

        private Task HandleException(HttpContext context, Exception ex)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            if(ex is StudentCouldNotDefendException)
            {
                return context.Response.WriteAsync(new ExceptionDetails
                {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    message = ex.Message
                }.ToString());
            }

            return  context.Response.WriteAsync(new ExceptionDetails
            {
                StatusCode = StatusCodes.Status500InternalServerError,
                message = "Something Happened"
        }.ToString());
        }
    }
}
