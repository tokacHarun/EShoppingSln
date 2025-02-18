using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Addresses.Commands.UpdateAddress
{
    public class UpdateAddressCommandHandler : BaseHandler, IRequestHandler<UpdateAddressCommandRequest, ResponseDto<UpdateAddressCommandResponse>>
    {
        public UpdateAddressCommandHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateAddressCommandResponse>> Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var data = _mapping.Map<Address, UpdateAddressCommandRequest>(request);
            unitOfWork.OpenTransactionAsync();
            var updateData = unitOfWork.GetWriteRepository<Address>().UpdateAsync(data);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();
            return new ResponseDto<UpdateAddressCommandResponse>().Success();
        }
    }
}
