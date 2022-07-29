using _7_MVC_GenericRepository.Entities.Concrete;
using System.Collections.Generic;

namespace _7_MVC_GenericRepository.Repositories.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        User CheckLogin(string name, string password);
    }
}
