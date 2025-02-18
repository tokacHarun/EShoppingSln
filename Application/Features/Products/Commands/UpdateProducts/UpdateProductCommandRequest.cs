using Application.Bases;
using MediatR;

namespace Application.Features.Products.Commands.UpdateProducts
{
    public class UpdateProductCommandRequest:IRequest<ResponseDto<UpdateProductCommandResponse>>
    {
    }
}
