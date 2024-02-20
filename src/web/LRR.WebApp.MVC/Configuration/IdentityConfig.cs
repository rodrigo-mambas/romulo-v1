﻿using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LRR.WebApp.MVC.Configuration
{
    public static  class IdentityConfig
    {
        public static void AddIdentityConfiguration(this IServiceCollection services)
        {
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                    options.LogoutPath = "/login";
                    options.AccessDeniedPath = "/acesso-negado";
                });
        }
        
        public static void UserIdentityConfiguration(this IApplicationBuilder app) 
        {
            app.UseAuthentication();
            app.UseAuthorization();
        }
    }
}