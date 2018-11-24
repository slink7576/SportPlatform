using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class User
    {
        public User()
        {
            this.Photos = new HashSet<Photo>();
        }

        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool SubmittedEmail { get; set; }
        public string Password { get; set; }
        public string PhotoUrl { get; set; }

        public int? WorkerId { get; set; }
        public Worker Worker { get; set; }

        public UserType UserType { get; set; }
        public ICollection<Photo> Photos { get; private set; }
    }
}
