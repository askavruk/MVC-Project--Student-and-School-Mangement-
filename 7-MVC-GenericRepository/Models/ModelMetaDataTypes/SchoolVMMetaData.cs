using _7_MVC_GenericRepository.Entities.Concrete;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _7_MVC_GenericRepository.Models.ModelMetaDataTypes
{
    public class SchoolVMMetaData
    {
        [Required(ErrorMessage = "İsim girişi zorunludur.")]
        [StringLength(100, ErrorMessage = "İsim uzunluğu en fazla 100 karakter olabilir.")]
        public string Name { get; set; }
        public IEnumerable<School> Schools { get; set; }
    }
}
