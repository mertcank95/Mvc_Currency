using Currency.Entities.EntityModels;
using Currency.Repository.Contracts;
using Currency.Service.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Service
{
    public class AnnouncementService : IAnnouncementService
    {
        private readonly IRepositoryManager _repositoryManager;

        public AnnouncementService(IRepositoryManager repositoryManager)
        {
            _repositoryManager = repositoryManager;
        }

        public async Task AnnouncementAllSave(List<string> announcementsContents)
        {
            List<Announcement> announcements = new List<Announcement>();

            foreach (var item in announcementsContents)
            {
                var newAnnouncement = new Announcement();
                newAnnouncement.StartTime = DateTime.Now;
                newAnnouncement.Contents = item;
                announcements.Add(newAnnouncement);
            }
          await _repositoryManager.AnnouncementRepository.AnnouncementAllSave(announcements);
        }

        public List<Announcement> GetAllAnnouncements()
        {
            return  _repositoryManager.AnnouncementRepository.FindAll(false).ToList();
        }
    }


}
