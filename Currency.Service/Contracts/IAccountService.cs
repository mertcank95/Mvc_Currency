using Currency.Entities.Dtos;
using Currency.Entities.EntityModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Service.Contracts
{
    public interface IAccountService
    {
        Task<(IdentityResult result, User user)> CreateUser(UserRegistrationDto userDto);
        User GetUserByEmail(string email);
        Task<IList<string>> GetUserRole(User user);
        Task<bool> EmailVerification(string userId, string token);
        public IQueryable<User> GetUsers();
       // Task<IdentityResult> CreateUser(User user,string password);
    }
}
