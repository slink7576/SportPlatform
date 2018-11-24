using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Application.Users.Commands.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PhotoUrl { get; set; }
    }
}
