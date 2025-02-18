using Application.Bases;
using MediatR;

namespace Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandRequest : IRequest<ResponseDto<CreateUserCommandResponse>>
    {
    }
}
