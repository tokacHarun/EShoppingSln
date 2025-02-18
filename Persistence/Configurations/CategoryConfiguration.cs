using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {


            var category1 = new Category(1, "Yiyecek - İçecek");
            var category2 = new Category(2, "Giyim");
            var category3 = new Category(3, "Kozmetik ürünler");
            var Category4 = new Category(4, "Aksesuar");

            builder.HasData(category1, category2, category3, Category4);
        }
    }
}
