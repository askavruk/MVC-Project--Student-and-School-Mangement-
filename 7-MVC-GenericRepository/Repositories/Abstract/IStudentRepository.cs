using _7_MVC_GenericRepository.Entities.Concrete;
using System.Collections.Generic;

namespace _7_MVC_GenericRepository.Repositories.Abstract
{
    public interface IStudentRepository :IRepository<Student>
    {
        IEnumerable<Student> GetAllIncludeSchools();
        Student GetByIncludeSchool(int id);
    }
}
