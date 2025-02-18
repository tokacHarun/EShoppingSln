namespace Application.Features.Orders.Queries.GetAllOrders
{
    public class GetAllOrderQueryResponse
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal TotalPrice { get; set; }
        public int AddressId { get; set; }
    }
}
