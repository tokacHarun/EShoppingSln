using Application.Bases;
using Application.Features.Addresses.Commands.CreateAddress;
using Application.Features.Addresses.Commands.UpdateAddress;
using Application.Features.Addresses.Queries.GetAllAddressQuery;
using Application.Features.Addresses.Queries.GetByIdAddressQuery;
using Application.Features.Categories.Commands.CreateCategory;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace EShoppingSlnAPI.Controllers.AddressesApi
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AddressController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ResponseDto<CreateCommandAddressResponse>> CreateAsync(CreateCommandAddressRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpPost]
        public async Task<ResponseDto<UpdateAddressCommandResponse>> UpdateAsync(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpGet]
        public async Task<ResponseDto<IList<GetAllAddressQueryResponse>>> GetAllAsync(GetAllAddressQueryRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpGet("{id}")]
        public async Task<ResponseDto<GetByIdAddressQueryResponse>> GetByIdAsync(int id)
        {
            return await _mediator.Send(new GetByIdAddressQueryRequest(id));
        }
    }
}
