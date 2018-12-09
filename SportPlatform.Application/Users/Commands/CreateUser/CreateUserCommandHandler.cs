using MediatR;
using SportPlatform.Domain.Entities;
using SportPlatform.Persistence;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SportPlatform.Application.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly SportPlatformContext _context;

        public CreateUserCommandHandler(SportPlatformContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {

            var entity = new User
            {
                Name = request.Name,
                Email = request.Email,
                Password = request.Password,
                SubmittedEmail = false,
            };
                
            if(request.IsSpecialist)
            {
                entity.Specialist = new Specialist();
            }
            else
            {
                entity.Client = new Client();
            }

            _context.Users.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.UserId;
        }
    }
}
