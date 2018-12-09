using MediatR;
using Microsoft.EntityFrameworkCore;
using SportPlatform.Persistence;
using System.Linq;
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
                 .SingleOrDefaultAsync(cancellationToken);

            if (user == null)
            {
                return false;
            }

            return true;
        }
    }
}
