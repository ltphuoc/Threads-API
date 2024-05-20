using Threads.DataTier;
using Threads.DataTier.Models;

namespace Threads.BusinessTier;

public class PostRepository : Repository<Post>, IPostRepository
{   private readonly ThreadsContext _Db;
    public PostRepository(ThreadsContext db) : base(db)
    {
          _Db = db;
    }
}
