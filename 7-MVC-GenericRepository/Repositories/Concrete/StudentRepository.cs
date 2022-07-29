using _7_MVC_GenericRepository.AppDbContext;
using _7_MVC_GenericRepository.Entities.Concrete;
using _7_MVC_GenericRepository.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace _7_MVC_GenericRepository.Repositories.Concrete
{
    public class StudentRepository : GenericReposisorty<Student>, IStudentRepository
    {
        private readonly ApplicationDbContext db;

        public StudentRepository(ApplicationDbContext db) :base(db)
        {
            this.db = db;
        }

        public IEnumerable<Student> GetAllIncludeSchools()
        {
            return db.Students.Include(s => s.School);
        }

        public Student GetByIncludeSchool(int id)
        {
            return db.Students.Include(s => s.School).FirstOrDefault(a => a.Id == id);
        }
    }
}
