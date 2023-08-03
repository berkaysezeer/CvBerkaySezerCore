using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class SocialMediaValidator : AbstractValidator<SocialMedia>
	{
		public SocialMediaValidator()
		{
			RuleFor(x => x.Url)
			.NotEmpty().WithMessage("Url alanı boş geçilemez")
			.MaximumLength(50).WithMessage("Maksimum 50 karakter girebilirisiz");

			RuleFor(x => x.Icon)
			.NotEmpty().WithMessage("Url alanı boş geçilemez");
		}
	}
}
