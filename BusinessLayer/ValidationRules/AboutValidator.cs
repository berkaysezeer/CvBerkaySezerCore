using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class AboutValidator : AbstractValidator<About>
	{
		public AboutValidator()
		{
			RuleFor(x => x.Title)
				.MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz")
				.NotEmpty().WithMessage("Başlık alanı boş geçilemez");

			RuleFor(x => x.Description)
				.MaximumLength(250).WithMessage("En fazla 250 karakter girebilirsiniz")
				.NotEmpty().WithMessage("Açıklama alanı boş geçilemez");

			RuleFor(x => x.Email)
				.MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz")
				.NotEmpty().WithMessage("E-posta alanı boş geçilemez");

			RuleFor(x => x.Phone)
				.MaximumLength(11).WithMessage("En fazla 11 karakter girebilirsiniz")
				.NotEmpty().WithMessage("Telefon alanı boş geçilemez");

			RuleFor(x => x.ImageUrl)
				.NotEmpty().WithMessage("Telefon alanı boş geçilemez");

		}
	}
}
