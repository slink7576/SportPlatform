using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Application.Users.Commands.ResetPassword
{
    public class ResetPasswordCommand : IRequest
    {
        public int Id { get; set; }
    }
}
