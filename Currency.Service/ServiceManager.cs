using Currency.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Service
{
    public class ServiceManager : IServiceManager
    {
        private readonly IAccountService _accountService;
        private readonly IAnnouncementService _announcementService;

        public ServiceManager(IAccountService accountService, IAnnouncementService announcementService)
        {
            _accountService = accountService;
            _announcementService = announcementService;
        }

        public IAccountService AccountService => _accountService;
        public IAnnouncementService AnnouncementService => _announcementService;

    }





}
