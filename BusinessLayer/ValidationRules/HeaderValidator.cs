using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class HeaderValidator : AbstractValidator<Header>
	{
		public HeaderValidator()
		{
			RuleFor(x => x.Head)
			  .NotEmpty().WithMessage("Başlık alanı boş geçilemez")
			  .MaximumLength(20).WithMessage("Maksimum 20 karakter girebilirsiniz");

			RuleFor(x => x.Title)
			  .NotEmpty().WithMessage("Ünvan alanı boş geçilemez")
			  .MaximumLength(50).WithMessage("Maksimum 50 karakter girebilirsiniz");

			RuleFor(x => x.Name)
			  .NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez")
			  .MaximumLength(30).WithMessage("Maksimum 30 karakter girebilirsiniz");
		}
	}
}
