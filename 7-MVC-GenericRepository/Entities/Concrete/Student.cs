using _7_MVC_GenericRepository.Entities.Abstract;
using _7_MVC_GenericRepository.Models.ModelMetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _7_MVC_GenericRepository.Entities.Concrete
{
    [ModelMetadataType(typeof(StudentVMMetaData))]
    public class Student :BaseEntity
    {
        public Student()
        {
            Lessons= new HashSet<Lesson>();
        }
        public string Class { get; set; }
        public int? SchoolID { get; set; }
        public School School { get; set; }
        public ICollection<Lesson> Lessons  { get; set; }
    }
}
