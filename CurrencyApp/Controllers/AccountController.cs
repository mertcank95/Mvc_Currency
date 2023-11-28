using AutoMapper;
using Currency.Entities.Dtos;
using Currency.Entities.EntityModels;
using Currency.Entities.Enums;
using Currency.Entities.Models;
using Currency.Service;
using Currency.Service.Contracts;
using CurrencyApp.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyApp.Controllers
{
    public class AccountController : BaseController
    {
  
        private readonly SignInManager<User> _signInManager;
        public AccountController(IServiceManager services, IMapper mapper, SignInManager<User> signInManager) : base(services, mapper)
        {
            _signInManager = signInManager;
        }

        public IActionResult SignIn()
        {
            return View();
        }


        public IActionResult SignUp()
        {
            return View();
        }


        public async Task SaveNewUser(UserRegistrationDto userDto)
        {
         
            var result = await _serviceManager.AccountService.CreateUser(userDto);
            
            if (result.result.Succeeded)
            {
                var token=Guid.NewGuid().ToString();
                var callbackUrl = Url.Action("EmailVerification", "Account", new { userId = result.user.Id, token = result.user.EmailVertificationCode }, Request.Scheme);
                Email email = new()
                {
                    SmtpHost = "smtp.gmail.com",
                    SmtPort = 587,
                    SenderEmail = "kiratlimertcan@gmail.com",
                    Password = "hdnsvixsrcbdeejl",
                    ToEmail = result.user.Email,
                    Subject = "test email",
                    Body = "<h1>This is a test email.</h1><p>Hello, this is a test email sent from the EmailService class.</p> </br> doğrulama link : " + callbackUrl
                };
                EmailService service = new EmailService();
                await service.SendEmailAsync(email);
            }
        }


        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {                
                ModelState.AddModelError("Error", "Invalid username or password");
            }
            var user=_serviceManager.AccountService.GetUserByEmail(model.Email);
            if(user is not null) 
            {
                var result = await _signInManager.PasswordSignInAsync(user.UserName, model.Password, model.CheckMeOut, true);
                if (result.Succeeded)
                {
                    var roles = await _serviceManager.AccountService.GetUserRole(user);
                    foreach (var role in roles)
                    {
                        if (role.Equals(UserRole.Admin.ToString()))
                        {
                            return RedirectToAction("Home", "AdminDashboard", new { area = "Admin" });
                        }
                    }
                    return Redirect("/UserProfile/Home");

                }
            }
            return Redirect("/Account/signin");
        }


        public async Task<IActionResult> Logout()
        {
           await _signInManager.SignOutAsync();
           return Redirect("/Home/Index"); 
        }


        public async Task<IActionResult> EmailVerification(string userId, string token)
        {
           var result = await _serviceManager.AccountService.EmailVerification(userId, token);
            if (result)
            {

            }
            return View();
        }

    }




}
