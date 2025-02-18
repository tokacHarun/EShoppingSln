using Application.Bases;
using MediatR;

namespace Application.Features.Addresses.Commands.UpdateAddress
{
    public class UpdateAddressCommandRequest:IRequest<ResponseDto<UpdateAddressCommandResponse>>
    {
        public UpdateAddressCommandRequest(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
