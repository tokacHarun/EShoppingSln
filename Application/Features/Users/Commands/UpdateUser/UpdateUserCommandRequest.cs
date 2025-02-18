using Application.Bases;
using MediatR;

namespace Application.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommandRequest : IRequest<ResponseDto<UpdateUserCommandResponse>>
    {
    }
}
