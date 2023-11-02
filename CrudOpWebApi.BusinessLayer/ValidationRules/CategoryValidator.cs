using CrudOpWebApi.EntityLayer.Entities;
using FluentValidation;
using System.Reflection.Metadata;

namespace CrudOpWebApi.BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Kategori Açıklamasını Boş Geçemezsiniz");
            RuleFor(x => x.Name).NotEmpty().MaximumLength(50).WithMessage("Kategori Adı En Fazla 50 Karakter Olmalıdır");
            RuleFor(x => x.Name).NotEmpty().MinimumLength(2).WithMessage("Kategori Adı En Az 2 Karakter Olmalıdır");
        }
    }
}
