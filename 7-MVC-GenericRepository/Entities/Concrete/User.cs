using _7_MVC_GenericRepository.Entities.Abstract;
using _7_MVC_GenericRepository.Entities.Enums;

namespace _7_MVC_GenericRepository.Entities.Concrete
{
    public class User: BaseEntity
    {
        public string Password { get; set; }
        public UserType UserType { get; set; }
    }
}
