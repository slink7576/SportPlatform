using MediatR;
using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommand : IRequest
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool SubmittedEmail { get; set; }
        public string Password { get; set; }
        public string PhotoUrl { get; set; }
        public UserType UserType { get; set; }
    }
}
