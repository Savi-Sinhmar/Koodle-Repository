using Microsoft.AspNetCore.Builder;
using Web.Infrastructure.Middleware;

namespace Web.Infrastructure.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseNoTrailingSlash(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<NoTrailingSlashMiddleware>();
        }
    }
}