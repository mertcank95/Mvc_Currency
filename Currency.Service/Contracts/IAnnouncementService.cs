using Currency.Entities.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Service.Contracts
{
    public interface IAnnouncementService
    {
        Task AnnouncementAllSave(List<string> announcementsContents);
        List<Announcement> GetAllAnnouncements();
    }
}
