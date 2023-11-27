using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Repository.Contracts
{
    public interface IRepositoryManager
    {
        IUserRepository UserRepository { get; }
        IAnnouncementRepository AnnouncementRepository { get; }
    }


}
