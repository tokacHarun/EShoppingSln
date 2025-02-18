using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Products.Commands.CreateProducts
{
    public class CreateCommandProductHandler : BaseHandler, IRequestHandler<CreateCommandProductRequest, ResponseDto<CreateCommandProductResponse>>
    {
        public CreateCommandProductHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<CreateCommandProductResponse>> Handle(CreateCommandProductRequest request, CancellationToken cancellationToken)
        {
            var mapData = _mapping.Map<Product, CreateCommandProductRequest>(request);
            unitOfWork.OpenTransactionAsync();
            var createData = await unitOfWork.GetWriteRepository<Product>().AddAsync(mapData);
            await unitOfWork.SaveAsync();
            await unitOfWork.CommitAsync();

            return new ResponseDto<CreateCommandProductResponse>().Success();
        }
    }
}
