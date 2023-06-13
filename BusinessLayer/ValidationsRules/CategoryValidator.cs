using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationsRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsin.");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı Boş Geçemezsin.");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En Az 3 Karakter Girmelisin.");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("En Fazla 20 Karakter Girmelisin.");


        }
    }
}
