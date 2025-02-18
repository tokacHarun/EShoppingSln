using Application.Bases;
using Application.Features.Users.Commands.UpdateUser;
using MediatR;

namespace Application.Features.Users.Queries.GetAllUser
{
    public class GetAllUserCommandRequest : IRequest<ResponseDto<IList<GetAllUserQueryResponse>>>
    {
        public GetAllUserCommandRequest(string name,int ıd)
        {
            Name = name;
            Id = ıd;
        }

        public string Name { get; }
        public int Id { get; }
    }
}
