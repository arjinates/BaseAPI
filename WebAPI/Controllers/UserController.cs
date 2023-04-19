using MediatR;
using Microsoft.AspNetCore.Mvc;
using SoftwareLab.Core.Features.User.Command.CreateUser;
using SoftwareLab.Core.Features.User.Query.GetUserById;

namespace SoftwareLab.WebAPI.Controllers
{
    
    public class UserController : BaseApiController
    {
        [HttpPost(Name = "CreateUser")]
        public async Task<int> CreateUser(CreateUserCommand createUserCommand)
        {
            return await Mediator.Send(createUserCommand);
        }

        [HttpGet(Name = "GetUser/{id}")]
        public async Task<GetUserByIdViewModel> GetUserById(int id)
        {
            return await Mediator.Send(new GetUserByIdQuery {  UserId = id });
        }
        
    }
}
