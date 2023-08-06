using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CvBerkaySezerCore.Areas.Writer.Models
{
    public class UserEditViewModel
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Email { get; set; }

        public string ImageUrl { get; set; }

        public IFormFile Image { get; set; }
    }
}
