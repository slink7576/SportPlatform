using SportPlatform.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SportPlatform.Application.Users.Queries.GetAllUsersQuery
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool SubmittedEmail { get; set; }
        public string PhotoUrl { get; set; }

        public int? WorkerId { get; set; }
        public Worker Worker { get; set; }

        public UserType UserType { get; set; }
        public ICollection<Photo> Photos { get; private set; }

        public bool IsWorker { get; set; }

        public static Expression<Func<User, UserDTO>> Projection
        {
            get
            {
                return c => new UserDTO
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
                    Worker = c.Worker,
                    WorkerId = c.WorkerId,
                    IsWorker = c.WorkerId == null ? false : true
                };
            }
        }

        public static UserDTO Create(User user)
        {
            return Projection.Compile().Invoke(user);
        }
    }
}
