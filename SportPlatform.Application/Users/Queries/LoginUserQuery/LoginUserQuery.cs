using MediatR;
using SportPlatform.Application.Users.Queries.GetUser;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Application.Users.Queries.LoginUserQuery
{
    public class LoginUserQuery : IRequest<bool>
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
