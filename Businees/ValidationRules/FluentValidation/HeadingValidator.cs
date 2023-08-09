using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businees.ValidationRules.FluentValidation
{
    public class HeadingValidator : AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(h => h.HeadingName).NotEmpty();
            RuleFor(h => h.HeadingName).MinimumLength(2);
            RuleFor(h => h.HeadingDate).NotEmpty();
        }
    }
}
