using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportPlatform.Application.Users.Queries.GetAllUsersQuery
{
    public class GetAllUsersQuery : IRequest<UsersListViewModel>
    {
    }
}
