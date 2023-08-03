using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class ServiceImageValidator : AbstractValidator<ServiceImage>
	{
		public ServiceImageValidator()
		{
			RuleFor(x => x.Title)
				.NotEmpty().WithMessage("Başlık alanı boş geçilemez")
				.MaximumLength(30).WithMessage("Maksimum 30 karakter girebilirsiniz");

			RuleFor(x => x.ImageUrl)
				.NotEmpty().WithMessage("Grösel alanı boş geçilemez");
		}
	}
}
