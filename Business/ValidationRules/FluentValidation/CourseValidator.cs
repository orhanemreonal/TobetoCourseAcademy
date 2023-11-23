using Entities.Concretes;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CourseValidator:AbstractValidator<Course>
    {
        //**
        public CourseValidator()
        {
            RuleFor(c=>c.CourseName).NotEmpty().WithMessage("Kurs adı boş geçilemez!");
            RuleFor(c => c.CourseName).MinimumLength(3);
            RuleFor(c => c.Price).NotEmpty();
            RuleFor(c => c.Price).GreaterThan(0);
            RuleFor(c => c.CourseName).Must(StartWithJ).WithMessage("Kurs adı 'J' ile başlamalıdır.");
        }

        private bool StartWithJ(string arg)
        {
            return arg.StartsWith("J");
        }
    }
}
