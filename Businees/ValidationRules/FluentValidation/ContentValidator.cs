using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ContentValidator : AbstractValidator<Content>
    {
        public ContentValidator()
        {
            RuleFor(c => c.ContentText).NotEmpty();
            RuleFor(c => c.ContentText).MinimumLength(2);
            RuleFor(c => c.ContentDate).NotEmpty();
        }
    }
}
