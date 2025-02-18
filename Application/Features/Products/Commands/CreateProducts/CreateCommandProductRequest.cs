using Application.Bases;
using MediatR;

namespace Application.Features.Products.Commands.CreateProducts
{
    public class CreateCommandProductRequest : IRequest<ResponseDto<CreateCommandProductResponse>>
    {
        public CreateCommandProductRequest(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
