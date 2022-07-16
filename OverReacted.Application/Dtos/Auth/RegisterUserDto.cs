using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverReacted.Application.Dtos.Auth
{
    public interface RegisterUserDto
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Compare(nameof(Password))]
        public string RePassword { get; set; }
    }

    public class RegisterUserDtoValidator : AbstractValidator<RegisterUserDto>
    {
        public RegisterUserDtoValidator()
        {
            RuleFor(n => n.Email).EmailAddress().WithMessage("Your Email Isn't Valid Please Provide Valid Identifier !");
            RuleFor(n => n.Password).NotEmpty().MinimumLength(8).NotNull().WithMessage("Your Password Is Weak , Please Choose Strong One !"); ;
        }
    }
}
