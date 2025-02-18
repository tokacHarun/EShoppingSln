using Application.Interfaces.AutoMappers;
using Application.Interfaces.Repositories;
using Application.Interfaces.UnitOfWorks;

using Microsoft.Extensions.DependencyInjection;
using Persistence.Concrete.Mapping;
using Persistence.Concrete.Repositories;
using Persistence.Concrete.UnitOfWork;
using Persistence.Context;

namespace Persistence
{
    public static class Registiration
    {
        public static void AddPersistence(this IServiceCollection services)
        {
            services.AddScoped(typeof(IReadRepostory<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddSingleton<IMapping, Mapper>();
            services.AddDbContext<AppDbContext>();
        }
    }
}
