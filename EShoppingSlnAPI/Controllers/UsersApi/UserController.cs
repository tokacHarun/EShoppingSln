using Application.Bases;
using Application.Features.Users.Commands.CreateUser;
using Application.Features.Users.Commands.UpdateUser;
using Application.Features.Users.Queries.GetAllUser;
using Application.Features.Users.Queries.GetByIdUser;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShoppingSlnAPI.Controllers.UsersApi
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ResponseDto<CreateUserCommandResponse>> CreateAsync(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpPost]
        public async Task<ResponseDto<UpdateUserCommandResponse>> UpdateAsync(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpGet]
        public async Task<ResponseDto<IList<GetAllUserQueryResponse>>> GetAllAsync(GetAllUserCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpGet("{id}")]
        public async Task<ResponseDto<GetByIdUserQueryResponse>> GetByIdAsync(GetByIdUserQueryRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
    }
}
