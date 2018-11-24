using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Application.Users.Queries.GetAllUsersQuery
{
    public class UsersListViewModel
    {
        public IEnumerable<UserDTO> Users { get; set; }
    }
}
