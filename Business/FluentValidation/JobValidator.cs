using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entitiy.Concrete;
using FluentValidation;

namespace Business.FluentValidation
{
    public class JobValidator:AbstractValidator<Job>
    {
        public JobValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Meslek adı boş geçilemez!");
        }
    }
}
