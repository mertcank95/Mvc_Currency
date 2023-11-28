using Currency.Service.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AnnouncementController : Controller
    {
        private readonly IServiceManager _serviceManager;

        public AnnouncementController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        public IActionResult Announcement()
        {
            return View();
        }
        
        [HttpPost]//
        public async Task SaveAnnouncement(List<string> announcement)
        {
           await _serviceManager.AnnouncementService.AnnouncementAllSave(announcement);
        }


    }



}
