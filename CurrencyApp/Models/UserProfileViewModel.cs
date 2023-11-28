using Currency.Entities.EntityModels;

namespace CurrencyApp.Models
{
    public class UserProfileViewModel
    {
        public User User { get; set; }
        public List<Announcement> Announcements { get; set; }

    }
}
