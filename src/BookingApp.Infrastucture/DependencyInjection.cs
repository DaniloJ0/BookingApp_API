﻿using BookingApp.Domain.Models.Jwt;
using BookingApp.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace NumberToWords.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IJwtTokenService, JwtTokenService>();

            return services;
        }
    }
}
