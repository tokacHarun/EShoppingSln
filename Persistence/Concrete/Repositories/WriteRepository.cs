using Application.Interfaces.Repositories;
using Domain.Comman;
using Microsoft.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Concrete.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : class, IBaseEntity, new()
    {

        private readonly AppDbContext _context;

        public WriteRepository(AppDbContext context)
        {
            _context = context;
        }
        private DbSet<T> Table
        {
            get => _context.Set<T>();
        }

        public async Task<T> AddAsync(T entity)
        {

            var tab = await Table.AddAsync(entity).ConfigureAwait(false);
            return tab.Entity;


        }

        public async Task AddRangeAsync(IList<T> entities)
        {
            await Table.AddRangeAsync(entities);
        }
        public async Task<T> UpdateAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }

        public async Task HardDeleteRangeAsync(IList<T> entity)
        {
            await Task.Run(() => Table.RemoveRange(entity));
        }

        public async Task SoftDeleteAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
        }

        public async Task<T> DeleteAsync(T entity)
        {
            await Task.Run(() => Table.Update(entity));
            return entity;
        }
    }
}
