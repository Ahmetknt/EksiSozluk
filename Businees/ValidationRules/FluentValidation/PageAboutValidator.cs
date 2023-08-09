using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businees.ValidationRules.FluentValidation
{
    public class PageAboutValidator : AbstractValidator<PageAbout>
    {
        public PageAboutValidator()
        {
            RuleFor(p => p.AboutMe).NotEmpty();
            RuleFor(h => h.AboutMe).MinimumLength(10);
            RuleFor(p => p.Email).NotEmpty();
            RuleFor(p => p.FirstName).NotEmpty();
            RuleFor(p => p.LastName).NotEmpty();
        }
    }
}
