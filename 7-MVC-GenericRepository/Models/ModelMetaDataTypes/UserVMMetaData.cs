using System.ComponentModel.DataAnnotations;

namespace _7_MVC_GenericRepository.Models.ModelMetaDataTypes
{
    public class UserVMMetaData
    {
        public int? Id { get; set; }

        [Required(ErrorMessage = "İsim girişi zorunludur.")]
        [StringLength(100, ErrorMessage = "İsim uzunluğu en fazla 100 karakter olabilir.")]
        public string Name { get; set; }

        [RegularExpression(@"^(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[^\w\d\s:])([^\s]){8,16}$", ErrorMessage = "Must contain 1 number (0-9), 1 uppercase letter, 1 lowercase letter, 1 non - alpha numeric number, 8 - 16 characters with no space")]
        public string Password { get; set; }
    }
}
