using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Users.Commands.UpdateUser
{
    public class UpdateUserCommandHandler : BaseHandler, IRequestHandler<UpdateUserCommandRequest, ResponseDto<UpdateUserCommandResponse>>
    {
        public UpdateUserCommandHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateUserCommandResponse>> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var mapData = _mapping.Map<User, UpdateUserCommandRequest>(request);
            unitOfWork.OpenTransactionAsync();
            var updateData = await unitOfWork.GetWriteRepository<User>().UpdateAsync(mapData);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();
            return new ResponseDto<UpdateUserCommandResponse>().Success();
        }
    }

}
