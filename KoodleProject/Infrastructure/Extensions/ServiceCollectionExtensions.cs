using System;
using Microsoft.Extensions.DependencyInjection;
using Web.Infrastructure.Middleware;

namespace Web.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddNoTrailingSlash(this IServiceCollection services,
            Action<NoTrailingSlashMiddlewareOptions> options)
        {
            return services.Configure(options);
        }
    }
}