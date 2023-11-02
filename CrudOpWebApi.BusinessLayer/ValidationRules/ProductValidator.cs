using CrudOpWebApi.EntityLayer.Entities;
using FluentValidation;

namespace CrudOpWebApi.BusinessLayer.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Başlık boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("İçerik boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat boş geçilemez");
            RuleFor(x => x.Name).MaximumLength(150).WithMessage("Lütfen 150 karakterden daha az veri girişi yapın");
            RuleFor(x => x.Name).MinimumLength(5).WithMessage("En az 3 karakter girebilirsiniz");
        }
    }
}
