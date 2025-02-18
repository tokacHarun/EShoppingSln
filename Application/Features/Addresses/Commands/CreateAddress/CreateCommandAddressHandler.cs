using Application.Bases;
using Application.Features.OrderItems.Queries.GetAllOrderItems;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Addresses.Commands.CreateAddress
{
    public class CreateCommandAddressHandler : BaseHandler, IRequestHandler<CreateCommandAddressRequest, ResponseDto<CreateCommandAddressResponse>>
    {
        public CreateCommandAddressHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateCommandAddressResponse>> Handle(CreateCommandAddressRequest request, CancellationToken cancellationToken)
        {
            var data = _mapping.Map<Address, CreateCommandAddressRequest>(request);
            unitOfWork.OpenTransactionAsync();
            var createData = unitOfWork.GetWriteRepository<Address>().AddAsync(data);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();
            return new ResponseDto<CreateCommandAddressResponse>().Success();

        }
    }
}
