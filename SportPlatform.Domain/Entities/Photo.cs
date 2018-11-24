using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Domain.Entities
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public DateTime PostDate { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
