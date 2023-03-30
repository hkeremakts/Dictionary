using Business.Constant;
using Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class WordValidator:AbstractValidator<Word>
    {
        public WordValidator()
        {
            RuleFor(x => x.Name.Trim()).Length(10,45);
            RuleFor(x => x.Definition1.Length).LessThan(300);
            RuleFor(x => x.Definition2.Length).LessThan(300);
            RuleFor(x => x.Definition3.Length).LessThan(300);
            RuleFor(x => x.Definition4.Length).LessThan(300);
            RuleFor(x => x.Definition5.Length).LessThan(300);
            RuleFor(x => x.Translation.Length).InclusiveBetween(2, 60);
        }
    }
}
