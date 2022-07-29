using _7_MVC_GenericRepository.AppDbContext;
using _7_MVC_GenericRepository.Entities.Concrete;
using _7_MVC_GenericRepository.Repositories.Abstract;
using System.Linq;

namespace _7_MVC_GenericRepository.Repositories.Concrete
{
    public class UserRepository : GenericReposisorty<User>, IUserRepository
    {
        private readonly ApplicationDbContext db;

        public UserRepository(ApplicationDbContext db) : base(db)
        {
            this.db = db; 
        }

        public User CheckLogin(string name, string pasword)
        {
            User user;
            user = db.User.SingleOrDefault(x => x.Name == name && x.Password == pasword);
            return user;
        }
    }
}
