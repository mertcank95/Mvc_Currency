using Currency.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly IUserRepository _userRepository;
        private readonly IAnnouncementRepository _announcementRepository;
        public RepositoryManager(IUserRepository userRepository, IAnnouncementRepository announcementRepository)
        {
            _userRepository = userRepository;
            _announcementRepository = announcementRepository;
        }
        public IUserRepository UserRepository => _userRepository;
        public IAnnouncementRepository AnnouncementRepository => _announcementRepository;
    }
}
