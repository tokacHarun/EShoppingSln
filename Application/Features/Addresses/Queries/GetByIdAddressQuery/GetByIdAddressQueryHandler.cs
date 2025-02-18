using Application.Bases;
using Application.Features.Categories.Queries.GetByIdCategory;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Addresses.Queries.GetByIdAddressQuery
{
    public class GetByIdAddressQueryHandler : BaseHandler, IRequestHandler<GetByIdAddressQueryRequest, ResponseDto<GetByIdAddressQueryResponse>>
    {
        public GetByIdAddressQueryHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<GetByIdAddressQueryResponse>> Handle(GetByIdAddressQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepostory<Address>().GetAsync(x => x.Id == request.Id);
            var mapData = _mapping.Map<GetByIdAddressQueryResponse, Address>(data);
            return new ResponseDto<GetByIdAddressQueryResponse>().Success(mapData);
        }
    }
}
