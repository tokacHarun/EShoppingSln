using Application.Bases;
using Application.Features.Products.Commands.CreateProducts;
using Application.Features.Products.Commands.UpdateProducts;
using Application.Features.Products.Queries.GetAllProducts;
using Application.Features.Products.Queries.GetByIdProducts;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShoppingSlnAPI.Controllers.ProductsApi
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ResponseDto<CreateCommandProductResponse>> CreateAsync(CreateCommandProductRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpPost]
        public async Task<ResponseDto<UpdateProductCommandResponse>> UpdateAsync(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpGet]
        public async Task<ResponseDto<IList<GetAllProductsQueryResponse>>> GetAllAsync(GetAllProductsQueryRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
        [HttpGet("{id}")]
        public async Task<ResponseDto<GetByIdProductQueryResponse>> GetByIdAsync(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            return await _mediator.Send(request, cancellationToken);
        }
    }
}
