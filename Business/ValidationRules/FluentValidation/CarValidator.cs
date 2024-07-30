using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.CarName).NotEmpty();
            RuleFor(p => p.CarName).MinimumLength(2);
            RuleFor(p => p.DailyPrice).GreaterThan(0);
            RuleFor(p => p.DailyPrice).GreaterThanOrEqualTo(50).When(p => p.BrandId == 1);
            RuleFor(p => p.CarName).Must(StartWithA);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
