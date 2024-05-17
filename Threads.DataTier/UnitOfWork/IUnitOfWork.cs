using Threads.DataTier.Repositories;

namespace Threads.DataTier.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        public IRepository<T> Repository<T>()
          where T : class;
        int Commit();

        Task<int> CommitAsync();
    }
}
