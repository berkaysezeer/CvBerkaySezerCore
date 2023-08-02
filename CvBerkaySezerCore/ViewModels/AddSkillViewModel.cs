using System.ComponentModel.DataAnnotations;

namespace CvBerkaySezerCore.ViewModels
{
	public class AddSkillViewModel
	{
		[StringLength(50, ErrorMessage = "En fazla 50 karakter girebilirsiniz")]
		[Required(ErrorMessage = "Başlık alanı boş geçilemez")]
		public string AddTitle { get; set; }
		public int AddRate { get; set; }
	}
}
