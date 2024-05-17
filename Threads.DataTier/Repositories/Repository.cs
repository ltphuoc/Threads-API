using Microsoft.EntityFrameworkCore;
using Threads.DataTier.Models;

namespace Threads.DataTier.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ThreadsContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository(ThreadsContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
    }
}
