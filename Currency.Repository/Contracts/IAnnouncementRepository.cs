using Currency.Entities.EntityModels;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Repository.Contracts
{
    public interface IAnnouncementRepository : IRepositoryBase<Announcement>
    {
        Task AnnouncementAllSave(List<Announcement> announcements);
    }
}
