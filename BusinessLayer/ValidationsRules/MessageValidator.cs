using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationsRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı Mail Adresini  Boş Geçemezsin.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Kısmını Boş Geçemezsin.");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaj Kısmını Boş Geçemezsin.");
            RuleFor(x => x.ReceiverMail).EmailAddress().WithMessage("Lütfen e mail adresi girin.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En Az 3 Karakter Girmelisin.");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("En Fazla 100 Karakter Girmelisin.");
        }
    }
}
