using MediatR;
using Microsoft.EntityFrameworkCore;
using SportPlatform.Application.Users.Queries.Shared;
using SportPlatform.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SportPlatform.Application.Users.Queries.GetAllUsersQuery
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, UsersListViewModel>
    {
        private readonly SportPlatformContext _context;

        public GetAllUsersQueryHandler(SportPlatformContext context)
        {
            _context = context;
        }

        public async Task<UsersListViewModel> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var model = new UsersListViewModel
            {
                Users = await _context.Users.Include(c => c.Specialist).Include(c => c.Client)
                 .Select(UserViewModel.Projection)
                 .ToListAsync(cancellationToken)
            };
            return model;
        }
    }
}
