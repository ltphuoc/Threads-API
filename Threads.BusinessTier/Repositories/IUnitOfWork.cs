using Threads.DataTier;

namespace Threads.BusinessTier;

public interface  IUnitOfWork
{
        IPostRepository Post {
            get;
        }
       

        public void Save();
        public void Dispose();
}
