using Currency.Entities.EntityModels;
using Repositories.Contracts;

namespace Currency.Repository.Contracts
{
    public interface IUserRepository:IRepositoryBase<User>
    {
        User GetUserByEmail(string userEmail);
        void CreateUser(User user);
    }


}
