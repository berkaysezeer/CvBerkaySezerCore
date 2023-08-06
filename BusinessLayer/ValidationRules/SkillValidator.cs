using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class SkillValidator : AbstractValidator<Skill>
	{
		public SkillValidator()
		{
			RuleFor(x => x.Title)
				.NotEmpty().WithMessage("Başlık alanı boş geçilemez")
				.MaximumLength(20).WithMessage("En fazla 20 karakter girebilirsiniz");
		}
	}
}
