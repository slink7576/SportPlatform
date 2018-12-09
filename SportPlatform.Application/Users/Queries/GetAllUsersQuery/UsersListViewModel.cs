using SportPlatform.Application.Users.Queries.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Application.Users.Queries.GetAllUsersQuery
{
    public class UsersListViewModel
    {
        public IEnumerable<UserViewModel> Users { get; set; }
    }
}
