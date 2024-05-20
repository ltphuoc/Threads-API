
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Threads.DataTier.Models;
using Threads.DataTier.Repositories;

  public class Repository<T> : IRepository<T> where T : class {
        private readonly ThreadsContext _db;
        internal DbSet<T> DbSet;

        public Repository(ThreadsContext db) {
            _db = db;
            DbSet = _db.Set<T>();
        }

        public void Add(T entity) {
            DbSet.Add(entity);
            _db.SaveChanges();
        }

        public T GetById(string key) {
            return DbSet.Find(key);
        }


        public ICollection<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, ICollection<T>> options = null, string includeProperties = null) {
            IQueryable<T> query = DbSet;
            if (filter != null) {
                query = query.Where(filter);
            }

            if (includeProperties != null) {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)) {
                    query = query.Include(includeProp);
                }
            }

            if (options != null) {
                return options(query).ToList();
            }

            return query.ToList();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null) {
            IQueryable<T> query = DbSet;
            if (filter != null) {
                query = query.Where(filter);
            }

            if (includeProperties != null) {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)) {
                    query = query.Include(includeProp);
                }
            }

            return query.AsNoTracking().FirstOrDefault();
        }

        public T SingleOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null) {
            IQueryable<T> query = DbSet;
            if (filter != null) {
                query = query.Where(filter);
            }

            if (includeProperties != null) {
                foreach (var includeProp in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)) {
                    query = query.Include(includeProp);
                }
            }

            return query.AsNoTracking().SingleOrDefault();
        }

        public void Remove(string key) {
            var entity = DbSet.Find(key);
            DbSet.Remove(entity);
            _db.SaveChanges();
        }

        public void Remove(T entity) {
            DbSet.Remove(entity);
            _db.SaveChanges();
        }

        public void Remove(ICollection<T> entities) {
            DbSet.RemoveRange(entities);
            _db.SaveChanges();
        }

        public void Update(T entity) {
            DbSet.Update(entity);
            _db.SaveChanges();
            _db.ChangeTracker.Clear();
        }

}
