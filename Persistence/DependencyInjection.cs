using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<BaseDbContext>(options =>
            {
                options.UseSqlite(connectionString);

            });

            services.AddScoped<IBaseDbContext>(provider => provider.GetService<BaseDbContext>());

            return services;
        }
    }
}
