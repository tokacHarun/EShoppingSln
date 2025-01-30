using Application.Interfaces.Repositories;
using Domain.Comman;

namespace Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IReadRepostory<T> GetReadRepostory<T>() where T : class, IBaseEntity, new();
        IWriteRepository<T> GetWriteRepository<T>() where T : class, IBaseEntity, new();
        void OpenTransaction();
        Task<int> SaveAsync();
        Task CommitAsync();
        void RollBack();
        int Save();
    }

}

