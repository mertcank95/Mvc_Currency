using AutoMapper;
using Currency.Entities.Dtos;
using Currency.Entities.EntityModels;
using Currency.Entities.Enums;
using Currency.Repository.Contracts;
using Currency.Service.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency.Service
{
    public class AccountService : IAccountService
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;
        private readonly IRepositoryManager _repositoryManager;
        public AccountService(RoleManager<IdentityRole> roleManager, UserManager<User> userManager,
            IMapper mapper, IRepositoryManager repositoryManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _mapper = mapper;
            _repositoryManager = repositoryManager;
        }

        public async Task<(IdentityResult result, User user)> CreateUser(UserRegistrationDto userDto)
        {
            var user = _mapper.Map<User>(userDto);
            user.EmailVertificationCode = Guid.NewGuid().ToString();
            var result = await _userManager.CreateAsync(user, userDto.Password);
            if (!result.Succeeded)
            {
               throw new Exception("User Could not be created");
            }
             var roleResult = await _userManager.AddToRoleAsync(user, UserRole.User.ToString());
             if (!roleResult.Succeeded)
             {
                throw new Exception();
             }
            return (result, user);

        }

        /*public async Task<IdentityResult> CreateUser(User user,string password)
        {
            // _repositoryManager.UserRepository.CreateUser(user);
            var result = await _userManager.CreateAsync(user, password);
            return result;

        }*/

        public User GetUserByEmail(string email)
        {
           return _repositoryManager.UserRepository.GetUserByEmail(email);
        }


        public async Task<IList<string>> GetUserRole(User user)
        {
            return await _userManager.GetRolesAsync(user);
        }

        public async Task<bool> EmailVerification(string userId, string token)
        {
            var user = await _userManager.FindByIdAsync(userId);
            user.EmailConfirmed = true;
            await _userManager.UpdateAsync(user);
            return true;
        }

        public IQueryable<User> GetUsers()
        {
            return _repositoryManager.UserRepository.FindAll(false);
        }

    }

}
