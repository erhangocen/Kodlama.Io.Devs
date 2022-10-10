﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Technologies.Commands.UpdateTechnology
{
    public class UpdateTechnologyValidator : AbstractValidator<UpdateTechnologyCommand>
    {
        public UpdateTechnologyValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.ProgrammingLanguageId).NotEmpty();
        }
    }
}
