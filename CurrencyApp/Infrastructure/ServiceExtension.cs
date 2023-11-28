using Currency.Entities.EntityModels;
using Currency.Repository;
using Currency.Repository.Contracts;
using Currency.Service;
using Currency.Service.Contracts;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CurrencyApp.Infrastructure
{
    public static class ServiceExtension
    {
        public static void ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<RepositoryContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DatabaseConnection"));
                    
                //options.EnableSensitiveDataLogging(true);
            });
        }


        public static void ConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, IdentityRole>(options => {

                //options.SignIn.RequireConfirmedEmail = false;//e-mail onaylamadığı sürece oturum açma durumu
                options.User.RequireUniqueEmail = true; //e-mail adresleri gerekli olsun mu
                //şifre Oluşturma
                options.Password.RequireUppercase = false;//büyük harf gereksin mi
                options.Password.RequireLowercase = false;
                options.Password.RequireDigit = false; //Rakam gereksin mi
                options.Password.RequiredLength = 6;//şifre uzunluğu

            }).AddEntityFrameworkStores<RepositoryContext>();
        }



        public static void ConfigureRepositoryRegistration(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryManager, RepositoryManager>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAnnouncementRepository, AnnouncementRepository>();
        }

        public static void ConfigureServiceRegistration(this IServiceCollection services)
        {
            services.AddScoped<IServiceManager, ServiceManager>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<IAnnouncementService, AnnouncementService>();
        }

        public static void ConfigureRouting(this IServiceCollection services)
        {
            services.AddRouting(options =>
            {
                options.LowercaseUrls = true;
                options.AppendTrailingSlash = false;
            });

        }


        public static void ConfigureApplicationCookie(this IServiceCollection services)
        {
            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = new PathString("/Account/Login");
                options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                options.AccessDeniedPath = new PathString("/Account/AccessDenied");
            });
        }


    }


}
