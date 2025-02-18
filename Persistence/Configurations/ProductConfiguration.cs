using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            #region Yiyecek - İçecek  
            #endregion

            var product1 = new Product(1, "Pizza", 1, 260, 240, "mükemmel");
            var product2 = new Product(2, "Hamburger", 1, 140, 110, "Başarılı");
            var product3 = new Product(3, "Limonata", 1, 80, 75, "İdare eder");
            var product4 = new Product(4, "Baklava", 1, 600, 560, "Orta derece");
            var product5 = new Product(5, "Soğuk kahve", 1, 115, 100, "Başarılı");
            var product6 = new Product(6, "Çay", 1, 20, 20, "Başarılı");
            var product7 = new Product(7, "Lahmacun", 1, 90, 75, "Çok güzel");
            var product8 = new Product(8, "Pide", 1, 350, 320, "Başarılı");
            var product9 = new Product(9, "Ayran", 1, 40, 35, "Başarılı");
            var product10 = new Product(10, "Şalgam", 1, 50, 40, "Çok acı");

            #region Giyim 
            #endregion

            var product11 = new Product(11, "Pantolon", 2, 1600, 1300, "Kaliteli");
            var product12 = new Product(12, "Mont", 2, 3200, 2900, "Mükemmel");
            var product13 = new Product(13, "Takım elbise", 2, 12500, 12000, "Başarılı");
            var product14 = new Product(14, "Krampon", 2, 4200, 3800, "Başarılı");
            var product15 = new Product(15, "Ayakkabı", 2, 2800, 2500, "Başarılı");
            var product16 = new Product(16, "T-Shirt", 2, 700, 650, "İdare eder");
            var product17 = new Product(17, "İç çamaşırı", 2, 200, 175, "Orta derece");

            #region Kozmetik ürünler
            #endregion

            var product18 = new Product(18, "Deodorant", 3, 110, 100, "Kalıcı");
            var product19 = new Product(19, "Parfüm", 3, 900, 755, "Kalıcı");
            var product20 = new Product(20, "Nemlendirici", 3, 150, 75, "Çok güzel");

            #region Aksesuar
            #endregion

            var product21 = new Product(21, "Kol Saati", 4, 550, 500, "Çok güzel");
            var product22 = new Product(22, "Gümüş Yüzük", 4, 2500, 2355, "Başarılı");
            var product23 = new Product(23, "Kolye", 4, 240, 220, "Harikulade");
            var product24 = new Product(24, "Bileklik", 4, 200, 180, "Kaliteli");

            builder.HasData(product1, product2, product3, product4, product5, product6, product7, product8, product9, product10, product11, product12, product13, product14, product15, product16, product17, product18, product19, product20, product21, product22, product23, product24);

        }
    }
}
