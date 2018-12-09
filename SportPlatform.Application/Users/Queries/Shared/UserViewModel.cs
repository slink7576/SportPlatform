using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SportPlatform.Application.Users.Queries.Shared
{
    public class UserViewModel
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool SubmittedEmail { get; set; }
        public string PhotoUrl { get; set; }

        public int? SpecialistId { get; set; }
        public Specialist Specialist { get; set; }

        public int? ClientId { get; set; }
        public Client Client { get; set; }

        public UserType UserType { get; set; }
        public ICollection<Photo> Photos { get; private set; }

        public bool IsSpecialist { get; set; }

        public static Expression<Func<User, UserViewModel>> Projection
        {
            get
            {
                return c => new UserViewModel
                {
                    UserId = c.UserId,
                    Age = c.Age,
                    Email = c.Email,
                    Name = c.Name,
                    Phone = c.Phone,
                    Photos = c.Photos,
                    PhotoUrl = c.PhotoUrl,
                    SubmittedEmail = c.SubmittedEmail,
                    Surname = c.Surname,
                    UserType = c.UserType,
                    Specialist = c.Specialist,
                    IsSpecialist = c.Specialist == null ? false : true,
                    ClientId = c.Client == null ? -1 : c.Client.ClientId,
                    SpecialistId = c.Specialist == null ? -1 : c.Specialist.SpecialistId,
                    Client = c.Client
                };
            }
        }

        public static UserViewModel Create(User user)
        {
            return Projection.Compile().Invoke(user);
        }
    }
}
