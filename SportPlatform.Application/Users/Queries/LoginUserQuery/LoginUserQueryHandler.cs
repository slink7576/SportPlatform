using MediatR;
using Microsoft.EntityFrameworkCore;
using SportPlatform.Application.Exceptions;
using SportPlatform.Application.Users.Queries.GetUser;
using SportPlatform.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SportPlatform.Application.Users.Queries.LoginUserQuery
{
    public class LoginUserQueryHandler : IRequestHandler<LoginUserQuery, bool>
    {
        private readonly SportPlatformContext _context;

        public LoginUserQueryHandler(SportPlatformContext sportPlatformContext)
        {
            _context = sportPlatformContext;
        }

        public async Task<bool> Handle(LoginUserQuery request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                 .Where(c => c.Email == request.Email &&
                            c.Password == request.Password)
                 .Select(UserViewModel.Projection)
                 .SingleOrDefaultAsync(cancellationToken);

            if (user == null)
            {
                return false;
            }

            return true;
        }
    }
}
