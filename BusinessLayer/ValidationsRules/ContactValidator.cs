using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationsRules
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Adresini  Boş Geçemezsin.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj Kısmını Boş Geçemezsin.");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("En Az 3 Karakter Girmelisin.");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("En Az 3 Karakter Girmelisin.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("En Fazla 50 Karakter Girmelisin.");



        }
    }
}
