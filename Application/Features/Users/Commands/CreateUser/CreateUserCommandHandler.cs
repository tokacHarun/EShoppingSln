using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Users.Commands.CreateUser
{
    public class CreateUserCommandHandler : BaseHandler, IRequestHandler<CreateUserCommandRequest, ResponseDto<CreateUserCommandResponse>>
    {
        public CreateUserCommandHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateUserCommandResponse>> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var mapData = _mapping.Map<User, CreateUserCommandRequest>(request);
            unitOfWork.OpenTransactionAsync();
            var createData = await unitOfWork.GetWriteRepository<User>().AddAsync(mapData);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();
            return new ResponseDto<CreateUserCommandResponse>().Success();

        }
    }
}
