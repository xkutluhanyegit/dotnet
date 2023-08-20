using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Products>
    {
        public ProductValidator()
        {
            RuleFor(p=>p.ProductName).NotEmpty().MaximumLength(10);
            RuleFor(p=>p.ProductName).MinimumLength(2);

        }
    }
}