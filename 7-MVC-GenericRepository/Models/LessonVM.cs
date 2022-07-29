
using _7_MVC_GenericRepository.Entities.Concrete;
using _7_MVC_GenericRepository.Models.ModelMetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _7_MVC_GenericRepository.Models
{
    [ModelMetadataType(typeof(LessonVMMetaData))]
    public class LessonVM 
    {
        public int? Id { get; set; }
        public string Name { get; set; }
      
    }
}
