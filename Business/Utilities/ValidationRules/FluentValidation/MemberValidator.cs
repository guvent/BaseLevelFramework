using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.Utilities.ValidationRules.FluentValidation
{
    public class MemberValidator:AbstractValidator<Member>
    {
        public MemberValidator()
        {
            RuleFor(m => m.FirstName).NotEmpty();
            RuleFor(m => m.LastName).NotEmpty();

            RuleFor(m => m.TCNO).NotEmpty();
            RuleFor(m => m.TCNO).Length(11);

            RuleFor(m => m.DateOfBirth).NotEmpty();
            RuleFor(m => m.DateOfBirth).LessThan(DateTime.Now);

            RuleFor(m => m.Email).NotEmpty();
            RuleFor(m => m.Email).EmailAddress();
        }
    }
}
