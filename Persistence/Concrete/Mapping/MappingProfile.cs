using Application.Features.Products.Queries.GetByIdProducts;
using AutoMapper;
using Domain.Entities;

namespace Persistence.Concrete.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<GetByIdProductQueryResponse, Product>();
        }
    }
}
