using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            var userRole1 = new UserRole("Alıcı", 1);
            var userRole2 = new UserRole("Alıcı", 2);
            var userRole3 = new UserRole("Satıcı", 1);
            var userRole4 = new UserRole("Satıcı", 2);

            builder.HasData(userRole1, userRole2, userRole3, userRole4);
        }
    }
}
