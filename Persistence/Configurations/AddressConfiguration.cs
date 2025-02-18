using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            var address1 = new Address(1, 2, 3, 4);
            var address2 = new Address(1, 2, 1, 4);
            var address3 = new Address(1, 5, 2, 2);
            var address4 = new Address(4, 2, 1, 1);

            builder.HasData(address1, address2, address3, address4);
        }
    }
}
