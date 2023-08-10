using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterMessageValidator : AbstractValidator<WriterMessage>
    {
        public WriterMessageValidator()
        {
            RuleFor(x => x.Sender)
              .NotEmpty().WithMessage("Gönderici alanı boş geçilemez")
              .MinimumLength(10).WithMessage("En az 10 karakter girmelisiniz")
              .MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz");

            RuleFor(x => x.Receiver)
              .NotEmpty().WithMessage("Alıcı alanı boş geçilemez")
              .MinimumLength(10).WithMessage("En az 10 karakter girmelisiniz")
              .MaximumLength(50).WithMessage("En fazla 50 karakter girebilirsiniz");

            RuleFor(x => x.Subject)
              .NotEmpty().WithMessage("Konu alanı boş geçilemez")
              .MaximumLength(100).WithMessage("En fazla 100 karakter girebilirsiniz");

            RuleFor(x => x.Subject)
              .NotEmpty().WithMessage("İçerik alanı boş geçilemez")
              .MaximumLength(5000).WithMessage("En fazla 5000 karakter girebilirsiniz");
        }
    }
}
