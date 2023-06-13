using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationsRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsin.");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsin.");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("En Az 2 Karakter Girmelisin.");
            RuleFor(x => x.TitleWriter).NotEmpty().WithMessage("Yazar Başlığı Boş Geçilemez.");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda kısmını boş geçemezsin.");
            RuleFor(x => x.WriterSurname).MinimumLength(3).WithMessage("En Az 3 Karakter Girmelisin.");
            RuleFor(x => x.WriterSurname).MaximumLength(50).WithMessage("En Fazla 50 Karakter Girmelisin.");
            RuleFor(x => x.WriterAbout).Must(x => x.Contains("a")).WithMessage("Hakkımda kısmında mutlaka a harfi bulunmalı.");
        }
    }
}
