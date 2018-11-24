using MediatR;
using SportPlatform.Application.Exceptions;
using SportPlatform.Domain.Entities;
using SportPlatform.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SportPlatform.Application.Users.Commands.DeleteUser
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        private readonly SportPlatformContext _context;

        public DeleteUserCommandHandler(SportPlatformContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Users.FindAsync(request.Id);

            if(entity == null)
            {
                throw new NotFoundException(nameof(User), request.Id);
            }

            _context.Users.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
