using MediatR;
using Microsoft.EntityFrameworkCore;
using SportPlatform.Application.Exceptions;
using SportPlatform.Domain.Entities;
using SportPlatform.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SportPlatform.Application.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Unit>
    {
        private readonly SportPlatformContext _context;

        public UpdateUserCommandHandler(SportPlatformContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Users
             .SingleAsync(c => c.UserId == request.UserId, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(User), request.UserId);
            }

            entity.Age = request.Age;
            entity.Email = request.Email;
            entity.Name = request.Name;
            entity.Password = request.Password;
            entity.Phone = request.Phone;
            entity.PhotoUrl = request.PhotoUrl;
            entity.SubmittedEmail = request.SubmittedEmail;
            entity.Surname = request.Surname;
            entity.UserType = request.UserType;

            _context.Users.Update(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
