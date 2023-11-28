using Currency.Entities.EntityModels;
using Currency.Service.Contracts;
using CurrencyApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyApp.Controllers
{
    
    public class UserProfileController : Controller
    {
        private readonly IServiceManager _services;

        public UserProfileController(IServiceManager services)
        {
            _services = services;
        }

        public IActionResult Home()
        {
            var profileModel = GetUserProfileData();
            return View(profileModel);
        }
        // @Html.Raw(System.Web.HttpUtility.HtmlDecode(question.Name))
        private UserProfileViewModel GetUserProfileData()
        {
            UserProfileViewModel model = new UserProfileViewModel();
            var userId = User.FindFirst(System.Security.Claims.ClaimTypes.NameIdentifier).Value;
            var user = _services.AccountService.GetUsers().Where(u=>u.Id.Equals(userId))
                .Select(u=> new User()
            {
                    Name = u.Name,
                    UserName = u.UserName,
                    Email = u.Email,
                    PhoneNumber = u.PhoneNumber,
                    Surname = u.Surname,
                    EmailConfirmed  = u.EmailConfirmed,
                    EmailVertificationCode=u.EmailVertificationCode,
                    Amount = u.Amount,
                    BirthDate = u.BirthDate
                    
            }).FirstOrDefault();

            model.Announcements = _services.AnnouncementService.GetAllAnnouncements();
            model.User = user;
            return model;
        }



    }
}
