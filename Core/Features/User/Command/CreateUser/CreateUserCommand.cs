using MediatR;
using SoftwareLab.Core.Exceptions;
using SoftwareLab.Core.Repositories;
using SoftwareLab.Core.Services;

namespace SoftwareLab.Core.Features.User.Command.CreateUser
{
    public class CreateUserCommand : IRequest<int>
    {
        public string Email { get; set; }

        public string FullName { get; set; }

        public DateTime BirthDate { get; set; }


        public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
        {
            private IUserRepository _userRepository;
            private IEmailService _emailService;

            public CreateUserCommandHandler(IUserRepository userRepository, IEmailService emailService)
            {
                _userRepository = userRepository;
                _emailService = emailService;
            }

            public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
            {
                Entities.User existingUser = await _userRepository.GetByEmail(request.Email);

                if (existingUser != null)
                {
                    throw new UserAlreadyRegisteredException($"User with email {request.Email} has already registered");
                }

                var user = await _userRepository.AddAsync(new Entities.User
                {
                    Email = request.Email,
                    FullName = request.FullName,
                    BirthDate = request.BirthDate,
                    CreatedDate = DateTime.UtcNow,
                    IsEnabled = true,
                });

                await _emailService.SendMail(user.Email, "Welcome to our website", "hey yo");

                return user.UserId;
            }
        }
    }
   
}
