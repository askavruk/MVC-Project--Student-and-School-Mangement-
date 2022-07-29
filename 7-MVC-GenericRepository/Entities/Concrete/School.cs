using _7_MVC_GenericRepository.Entities.Abstract;
using System.Collections.Generic;

namespace _7_MVC_GenericRepository.Entities.Concrete
{
    public class School :BaseEntity
    {
        public School()
        { 
            Students = new HashSet<Student>();
            Lessons = new HashSet<Lesson>();
        }
        public ICollection<Student> Students{ get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
