using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.Utilities.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(t => t.ProductName).NotEmpty();
            RuleFor(t => t.ProductName).Length(2, 20);
            RuleFor(t => t.CategoryID).NotEmpty();
            RuleFor(t => t.QuantityPerUnit).NotEmpty();
            RuleFor(t => t.UnitPrice).GreaterThan(10);
        }
    }
}
