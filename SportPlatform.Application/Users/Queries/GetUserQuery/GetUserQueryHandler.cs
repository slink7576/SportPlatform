using MediatR;
using Microsoft.EntityFrameworkCore;
using SportPlatform.Application.Exceptions;
using SportPlatform.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SportPlatform.Application.Users.Queries.GetUser
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, UserViewModel>
    {
        private readonly SportPlatformContext _context;

        public GetUserQueryHandler(SportPlatformContext sportPlatformContext)
        {
            _context = sportPlatformContext;
        }

        public async Task<UserViewModel> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .Where(c => c.UserId == request.Id)
                .Select(UserViewModel.Projection)
                .SingleOrDefaultAsync(cancellationToken);

            if(user == null)
            {
                throw new NotFoundException(nameof(user), request.Id);
            }

            return user;
        }
    }
}
