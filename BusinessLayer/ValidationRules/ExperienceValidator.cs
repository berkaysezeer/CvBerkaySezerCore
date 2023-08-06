using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class ExperienceValidator : AbstractValidator<Experience>
	{
		public ExperienceValidator()
		{
			RuleFor(x => x.Title)
				.NotEmpty().WithMessage("Başlık alanı boş geçilemez")
				.MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz");

			RuleFor(x => x.Description)
				.NotEmpty().WithMessage("Açıklama alanı boş geçilemez")
				.MaximumLength(200).WithMessage("En fazla 200 karakter girebilirsiniz");

			RuleFor(x => x.Date)
				.NotEmpty().WithMessage("Tarih Aralığı 20 karakter girebilirsiniz");

			RuleFor(x => x.ImageUrl)
				.NotEmpty().WithMessage("Görsel alanı boş geçilemez");
		}
	}
}
