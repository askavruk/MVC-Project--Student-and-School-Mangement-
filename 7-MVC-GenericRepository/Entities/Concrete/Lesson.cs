using _7_MVC_GenericRepository.Entities.Abstract;
using System.Collections.Generic;

namespace _7_MVC_GenericRepository.Entities.Concrete
{
    public class Lesson : BaseEntity
    {
        public Lesson()
        {
            Students = new HashSet<Student>();
            Schools = new HashSet<School>();
        }
        public ICollection<Student> Students { get; set; }
        public ICollection<School> Schools { get; set; }
    

    }
}