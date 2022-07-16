using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Application.Dtos.Auth
{
    public class ResetUserPasswordDto
    {
        public string Email { get; set; }
    }

    public class ResetUserPasswordDtoValidator : AbstractValidator<ResetUserPasswordDto>
    {
        public ResetUserPasswordDtoValidator()
        {
            RuleFor(n => n.Email).EmailAddress().WithMessage("Your Email Isn't Valid Please Provide Valid Identifier !");
        }
    }
}
