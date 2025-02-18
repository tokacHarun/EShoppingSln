using Domain.Comman;
using Domain.Enums;

namespace Domain.Entities
{
    public class Order : BaseEntity
    {
        public Order()
        {

        }
        public Order(int id, decimal totalPrice, int userId, int addressId, OrderStatusTypeEnum orderStatusTypeId)
        {
            this.Id = id;
            this.TotalPrice = totalPrice;
            this.UserId = userId;
            this.AddressId = addressId;
            this.OrderStatusType = orderStatusTypeId;
        }
        public decimal TotalPrice { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public IList<OrderItem> OrderItems { get; set; }
        public OrderStatusTypeEnum OrderStatusType { get; set; }

    }
}
