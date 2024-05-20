using Threads.DataTier;
using Threads.DataTier.Models;

namespace Threads.BusinessTier;

public class UnitOfWork : IUnitOfWork
{

    private readonly ThreadsContext _db;
    public IPostRepository Post { get; private set; }

    public UnitOfWork(ThreadsContext db){
        _db = db;
        Post = new PostRepository(_db);
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public void Save()
    {
        throw new NotImplementedException();
    }
}
