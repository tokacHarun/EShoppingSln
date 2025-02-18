using Application.Interfaces.Repositories;
using Application.Interfaces.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Persistence.Concrete.Repositories;
using Persistence.Context;

namespace Persistence.Concrete.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public async Task CommitAsync()
        {
            await _context.Database.CommitTransactionAsync();
        }


        public async ValueTask DisposeAsync()

            => await _context.DisposeAsync();



        public void OpenTransactionAsync()
        {
            _context.Database.BeginTransactionAsync();
        }

        public void RollBack()
        {
            _context.Database.RollbackTransaction();
        }

        public int Save()

            => _context.SaveChanges();

        public async Task<int> SaveAsync()
        {
            try
            {
                var result = await _context.SaveChangesAsync();
                return result;
            }
            catch (Exception ex)
            {
                RollBack();
                throw new Exception(ex.Message);

            }
        }

        IReadRepostory<T> IUnitOfWork.GetReadRepostory<T>()

             => new ReadRepository<T>(_context);

        IWriteRepository<T> IUnitOfWork.GetWriteRepository<T>()
         => new WriteRepository<T>(_context);
    }
}
