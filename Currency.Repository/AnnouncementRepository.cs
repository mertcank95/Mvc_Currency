using Currency.Entities.EntityModels;
using Currency.Repository.Contracts;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Repository
{
    public class AnnouncementRepository : RepositoryBase<Announcement>,IAnnouncementRepository
    {
        public AnnouncementRepository(RepositoryContext context) : base(context)
        {

        }

        public async Task AnnouncementAllSave(List<Announcement> announcements)
        {
          _context.Announcements.AddRange(announcements);
          await  _context.SaveChangesAsync();
        }
    }


}
