using Domain.Comman;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace Application.Interfaces.Repositories
{
    public interface IReadRepostory<T> where T : class,IBaseEntity, new()
    {
        Task<IList<T>> GetAllAsync(Expression<Func<T, bool>>? predicate = null,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
               Expression<Func<T, T>>? selector = null,
            bool enableTracking = false);

        Task<IList<T>> GetAllByPagingAsync(Expression<Func<T, bool>>? predicate = null,
           Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
           Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy = null,
           bool enableTracking = false, int currentPage = 1, int pageSize = 3);

        Task<T> GetAsync(Expression<Func<T, bool>> predicate,
           Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
           bool enableTracking = false);

        Task<T> FindAsync(Expression<Func<T, bool>> predicate,
            Func<IQueryable<T>, IIncludableQueryable<T, object>>? include = null,
            bool enableTracking = false);

        Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null);
    }
}
