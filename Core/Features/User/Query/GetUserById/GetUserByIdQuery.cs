using MediatR;
using SoftwareLab.Core.Exceptions;
using SoftwareLab.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareLab.Core.Features.User.Query.GetUserById
{
    public class GetUserByIdQuery : IRequest<GetUserByIdViewModel>
    {
        public int UserId { get; set; }

        public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, GetUserByIdViewModel>
        {
            private readonly IUserRepository _userRepository;

            public GetUserByIdQueryHandler(IUserRepository userRepository)
            {
                _userRepository = userRepository;
            }

            public async Task<GetUserByIdViewModel> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
            {
                var user = await _userRepository.GetByIdAsync(request.UserId);

                if (user == null) { throw new UserNotFoundException($"User cannot be found with Id {request.UserId}"); }

                return new GetUserByIdViewModel
                {
                    Email = user.Email,
                    FullName = user.FullName,
                };
                
            }
        }
    }
}
