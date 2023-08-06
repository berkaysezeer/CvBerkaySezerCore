using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class ProjectValidator : AbstractValidator<Project>
	{
		public ProjectValidator()
		{
			RuleFor(x => x.Title)
				.NotEmpty().WithMessage("Başlık alanı boş geçilemez")
				.MaximumLength(30).WithMessage("En fazla 30 karakter girebilirsiniz");

			RuleFor(x => x.Description)
				.NotEmpty().WithMessage("Açıklama alanı boş geçilemez")
				.MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz");

			RuleFor(x => x.ImageUrl)
				.NotEmpty().WithMessage("Görsel alanı boş geçilemez");
		}
	}
}
