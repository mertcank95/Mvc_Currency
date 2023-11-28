using Currency.Entities.EntityModels;
using Currency.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CurrencyApp.Infrastructure
{
    public static class ApplicationExntension
    {
        public static void ConfigureAndCheckMigration(this IApplicationBuilder app)
        {
            RepositoryContext context = app
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<RepositoryContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

        }


        public static void ConfigureLocalization(this WebApplication app)
        {
            app.UseRequestLocalization(options =>
            {
                options.AddSupportedCultures("tr-TR")
                    .AddSupportedCultures("tr-TR")
                    .SetDefaultCulture("tr-TR");
            });
        }

        public static async void ConfigureAdminUser(this IApplicationBuilder app)
        {
            const string adminUser = "Admin";
            const string adminEmail = "admin@admin.com";
            const string adminPassword = "Admin-1234";

            UserManager<User> userManager = app
                .ApplicationServices
                .CreateScope()
                .ServiceProvider
                .GetRequiredService<UserManager<User>>();

            RoleManager<IdentityRole> roleManager = app
                .ApplicationServices
                .CreateAsyncScope()
                .ServiceProvider
                .GetRequiredService<RoleManager<IdentityRole>>();

            var user = await userManager.FindByEmailAsync(adminEmail);
            if (user is null)
            {
                user = new User()
                {
                    Email = "admin@admin.com",
                    IsActive=true,
                    PhoneNumber = "55664488",
                    UserName = adminUser,
                    EmailConfirmed = true,
                };
                var result = await userManager.CreateAsync(user, adminPassword);
                if (!result.Succeeded)
                {
                    throw new Exception("Admin User could not created.");
                }

                var roleResult = await userManager.AddToRolesAsync(user,
                   roleManager
                    .Roles
                    .Select(r => r.Name)
                    .ToList()
                );

                if (!roleResult.Succeeded)
                {
                    throw new Exception("System have problems with role defination");

                }

            }


        }





















    }


}
