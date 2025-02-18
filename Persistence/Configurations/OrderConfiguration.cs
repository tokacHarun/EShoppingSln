using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            var order1 = new Order(1, 1300, 4, 2, Domain.Enums.OrderStatusTypeEnum.Road);
            var order2 = new Order(2, 650, 4, 3, Domain.Enums.OrderStatusTypeEnum.ORDERPREPARATION);
            var order3 = new Order(3, 260, 4, 2, Domain.Enums.OrderStatusTypeEnum.Completed);
            var order4 = new Order(4, 450, 4, 1, Domain.Enums.OrderStatusTypeEnum.Shipped);
            var order5 = new Order(5, 700, 4, 3, Domain.Enums.OrderStatusTypeEnum.Completed);

            builder.HasData(order1, order2, order3, order4, order5);
        }
    }
}
