using Threads.DataTier.Models;
using Threads.DataTier.UnitOfWork;

namespace Threads.BusinessTier.Services
{
    public class TestService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TestService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<User> GetAll()
        {
            return _unitOfWork.Repository<User>().GetAll();
        }

    }
}
