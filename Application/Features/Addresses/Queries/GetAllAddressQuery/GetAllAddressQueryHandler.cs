using Application.Bases;
using Application.Interfaces.AutoMappers;
using Application.Interfaces.UnitOfWorks;
using Domain.Entities;
using MediatR;

namespace Application.Features.Addresses.Queries.GetAllAddressQuery
{
    public class GetAllAddressQueryHandler : BaseHandler, IRequestHandler<GetAllAddressQueryRequest, ResponseDto<IList<GetAllAddressQueryResponse>>>
    {
        public GetAllAddressQueryHandler(IMapping mapping, IUnitOfWork unitOfWork) : base(mapping, unitOfWork)
        {
        }

        public async Task<ResponseDto<IList<GetAllAddressQueryResponse>>> Handle(GetAllAddressQueryRequest request, CancellationToken cancellationToken)
        {
            var data = await unitOfWork.GetReadRepostory<Address>().GetAllAsync(x => !x.IsDeleted);
            var dataMapped = _mapping.Map<GetAllAddressQueryResponse, Address>(data);
            return new ResponseDto<IList<GetAllAddressQueryResponse>>().Success(dataMapped);

        }
    }
}
