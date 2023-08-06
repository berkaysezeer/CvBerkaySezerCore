using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AnnouncementValidator : AbstractValidator<Announcement>
    {
        public AnnouncementValidator()
        {
            RuleFor(x => x.Content)
                .MaximumLength(500).WithMessage("En fazla 500 karekter girebilirsiniz")
                .MinimumLength(10).WithMessage("En az 10 karekter girmelisiniz")
                .NotEmpty().WithMessage("İçerik alanı boş geçilemez");

            RuleFor(x => x.Title)
                .MaximumLength(100).WithMessage("En fazla 100 karekter girebilirsiniz")
                .MinimumLength(5).WithMessage("En az 5 karekter girmelisiniz")
                .NotEmpty().WithMessage("Başlık alanı boş geçilemez");

        }
    }
}
