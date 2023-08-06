using System.ComponentModel.DataAnnotations;

namespace CvBerkaySezerCore.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [Compare("ConfirmPassword", ErrorMessage = "Şifreler uyuşmuyor")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Email { get; set; }
    }
}
