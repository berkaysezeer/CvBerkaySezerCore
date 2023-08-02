using System.ComponentModel.DataAnnotations;

namespace CvBerkaySezerCore.Areas.Admin.ViewComponents
{
    public class AddServiceViewModel
    {

        [StringLength(50, ErrorMessage = "En fazla 50 karakter girebilirsiniz")]
        [Required(ErrorMessage = "Başlık alanı boş geçilemez")]
        public string AddTitle { get; set; }

        public string AddImageUrl { get; set; }

    }
}
