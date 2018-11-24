﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Application.Users.Commands.DeleteUser
{
    public class DeleteUserCommandValidator : AbstractValidator<DeleteUserCommand>
    {
        public DeleteUserCommandValidator()
        {
            RuleFor(c => c.Id).NotEmpty();
        }
    }
}
