using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            var user1 = new User("İbrahim", "Çakmak", 1, "osp63", new DateTime(2005, 10, 10), "iboçakmak@gmail.com");
            var user2 = new User("Mücahit", "Bağlan", 2, "müsabağ51", new DateTime(1995, 4, 25), "mücodayi@gmail.com");
            var user3 = new User("Harun", "Tokaç", 3, "haret51", new DateTime(2002, 02, 13), "tokacharun5151@gmail.com");
            var user4 = new User("Yunus", "Tokaç", 4, "yunus51", new DateTime(2000, 04, 26), "tokacharun5151@gmail.com");
            builder.HasData(user1, user2, user3, user4);
        }
    }
}
