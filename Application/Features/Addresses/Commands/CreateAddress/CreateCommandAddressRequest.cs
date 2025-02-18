using Application.Bases;
using MediatR;

namespace Application.Features.Addresses.Commands.CreateAddress
{
    public class CreateCommandAddressRequest : IRequest<ResponseDto<CreateCommandAddressResponse>>
    {
        public CreateCommandAddressRequest(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
