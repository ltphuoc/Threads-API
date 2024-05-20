using System.Linq.Expressions;

namespace Threads.DataTier.Repositories
{
    public interface IRepository<T> where T : class {
        T GetById(string id);

        ICollection<T> GetAll(
                  Expression<Func<T, bool>> filter = null,
                  Func<IQueryable<T>, ICollection<T>> options = null,
                  string includeProperties = null
                  );

        T GetFirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        T SingleOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

        void Add(T entity);

        void Remove(string id);

        void Remove(T entity);

        void Remove(ICollection<T> entities);

        void Update(T entity);
    }
}
