﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;

namespace MovieStore.MVC.Helpers
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    //Always make sure you have Exceptionmiddlewares register at the very beginning
    public class MovieScoreExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<MovieScoreExceptionMiddleware> _logger;
        //In ASP.NET Core logging() is builtin to the framework

        public MovieScoreExceptionMiddleware(RequestDelegate next, ILogger<MovieScoreExceptionMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                _logger.LogInformation("MovieScoreExceptionMiddleware is called");
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Exception Happened: {ex}");
                await HandleException(httpContext, ex);
            }
            // return _next(httpContext);
        }
        public async Task HandleException(HttpContext context, Exception exception)
        {
            // Step 1: You need to log the exception details such as
            //Most Popular Logging frameworks in .NET are
            //Serilog(use this one) NLog and Log4net(nuget)
            // 1. Exception message
            // 2. Exception StackTrace
            // 3. When the exception happened. Datetime
            // 4. The User Info
            // 5. Where in our code the exception happened
            _logger.LogInformation($"---------------Start OF LOGGING-------------------");
            _logger.LogError($"Exception Message:{exception.Message}");
            _logger.LogError($"Exception Stack Trace:{exception.StackTrace}");
            _logger.LogInformation($"Exception for User:{context.User.Identity.Name}");
            _logger.LogInformation($"Exception happened on:{DateTime.UtcNow}");
            _logger.LogInformation($"---------------END OF LOGGING-------------------");
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            // Step 2: Send Notification(Email preferred) to the Dev team ex: dev@antra.com
            //Mailkit(free)--sned emails, SendGrid(paid, but free for some time)
            // Step 3: Show a friendly error page to the User
            context.Response.Redirect("/Home/Error");
            await Task.CompletedTask;
        }
    }
    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class MovieStoreExceptionMiddlewareExtensions
    {
        public static IApplicationBuilder UseMovieScoreExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MovieScoreExceptionMiddleware>();
        }
    }
}
