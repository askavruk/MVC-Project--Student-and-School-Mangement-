using _7_MVC_GenericRepository.Models.ModelMetaDataTypes;
using Microsoft.AspNetCore.Mvc;
using System;

namespace _7_MVC_GenericRepository.Entities.Abstract
{
   
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; } =DateTime.Now;
    }
}
