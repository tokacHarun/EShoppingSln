using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Commands.UpdateProducts
{
    public class UpdateProductCommandHandler : BaseHandler, IRequestHandler<UpdateProductCommandRequest, ResponseDto<UpdateProductCommandResponse>>
    {
        public UpdateProductCommandHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<UpdateProductCommandResponse>> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var mapData = _mapping.Map<Product, UpdateProductCommandRequest>(request);
            unitOfWork.OpenTransactionAsync();
            var updateData = unitOfWork.GetWriteRepository<Product>().UpdateAsync(mapData);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();
            return new ResponseDto<UpdateProductCommandResponse>().Success();
        }
    }
}
