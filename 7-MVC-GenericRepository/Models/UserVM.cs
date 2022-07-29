using Microsoft.AspNetCore.Mvc;

namespace _7_MVC_GenericRepository.Models
{
    [ModelMetadataType(typeof(UserVM))]
    public class UserVM
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
