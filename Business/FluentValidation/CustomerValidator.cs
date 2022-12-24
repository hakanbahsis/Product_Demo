using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitiy.Concrete;
using FluentValidation;

namespace Business.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsin boş geçilemez!");
            RuleFor(x => x.Name).Length(3).WithMessage("Şehir adı 3 karakterden az olamaz!");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir adı boş geçilemez!");
        }
    }
}
