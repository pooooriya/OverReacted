using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Application.Dtos.Auth
{
    public class LoginUserDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class LoginUserDtoValidator : AbstractValidator<LoginUserDto>
    {
        public LoginUserDtoValidator()
        {
            RuleFor(n => n.Email).EmailAddress().WithMessage("Your Email Isn't Valid Please Provide Valid Identifier !");
            RuleFor(n => n.Password).NotEmpty().MinimumLength(8).NotNull().WithMessage("Your Password Is Weak , Please Choose Strong One !"); ;
        }
    }
}
