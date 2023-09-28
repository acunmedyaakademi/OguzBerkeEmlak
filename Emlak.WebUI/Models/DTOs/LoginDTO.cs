using System.ComponentModel.DataAnnotations;

namespace Emlak.WebUI.Models.DTOs
{
    public class LoginDTO
    {

        [Required(AllowEmptyStrings =false,ErrorMessage ="Kullanici Adi Zorunludur")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Sifre  Zorunludur")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
