using System.ComponentModel.DataAnnotations;

namespace CvBerkaySezerCore.ViewModels
{
    public class AddProjectViewModel
    {
        [StringLength(50, ErrorMessage = "En fazla 50 karakter girebilirsiniz")]
        [Required(ErrorMessage = "Başlık alanı boş geçilemez")]
        public string AddTitle { get; set; }

        public string AddImageUrl { get; set; }

        [StringLength(256, ErrorMessage = "En fazla 256 karakter girebilirsiniz")]
        [Required(ErrorMessage = "Url alanı boş geçilemez")]
        public string AddProjectUrl { get; set; }
    }
}
