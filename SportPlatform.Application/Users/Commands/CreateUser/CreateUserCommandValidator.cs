using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Application.Users.Commands.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(c => c.Email).NotEmpty();
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(c => c.Password).NotEmpty();
            RuleFor(c => c.Email).EmailAddress();
        }
    }
}
