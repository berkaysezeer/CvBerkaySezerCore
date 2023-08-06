using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class ContactValidator : AbstractValidator<Contact>
	{
		public ContactValidator()
		{
			RuleFor(x => x.FullName)
			.NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez")
			.MaximumLength(50).WithMessage("En fazla 50 karakter girebilirisiz")
			.MinimumLength(3).WithMessage("En az 3 karakter girmelisiniz");

			RuleFor(x => x.Email)
			.NotEmpty().WithMessage("E-posta alanı boş geçilemez")
			.MaximumLength(50).WithMessage("En fazla 50 karakter girebilirisiz")
			.MinimumLength(10).WithMessage("En az 10 karakter girmelisiniz");

			RuleFor(x => x.Subject)
			.NotEmpty().WithMessage("Konu alanı boş geçilemez")
			.MaximumLength(50).WithMessage("En fazla 50 karakter girebilirisiz")
			.MinimumLength(3).WithMessage("En az 10 karakter girmelisiniz");

			RuleFor(x => x.Date)
			.NotEmpty().WithMessage("Tarih alanı boş geçilemez");

			RuleFor(x => x.Message)
			.NotEmpty().WithMessage("Ad Soyad alanı boş geçilemez")
			.MaximumLength(1000).WithMessage("En fazla 1000 karakter girebilirisiz")
			.MinimumLength(10).WithMessage("En az 10 karakter girmelisiniz");
		}
	}
}
