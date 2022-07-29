
using _7_MVC_GenericRepository.Entities.Concrete;
using _7_MVC_GenericRepository.Models.ModelMetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _7_MVC_GenericRepository.Models
{
    public class StudentsWithSchoolsWM
    {
        public StudentsWithSchoolsWM()
        {
            Schools= new List<School>();
        }

        public Student Student { get; set; }
   
        public School School { get; set; }
        public IEnumerable<School> Schools { get; set; }
    }
}
