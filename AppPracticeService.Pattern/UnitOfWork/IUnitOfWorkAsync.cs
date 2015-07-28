using System.Threading;
using System.Threading.Tasks;
using AppPracticeService.Pattern.Infrastructure;
using AppPracticeService.Pattern.Repositories;

namespace AppPracticeService.Pattern.UnitOfWork
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class, IObjectState;
    }
}