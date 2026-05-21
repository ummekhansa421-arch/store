using Apps.Core.Utilities;

namespace Apps.Core.Models
{
    public class Order
    {
        public string Id { get; set; }

        public string CustomerId { get; set; }

        public string CustomerName { get; set; }

        public DateTime OrderDate { get; set; }

        public OrderStatusEnum Status { get; set; }

        public PaymentMethodEnum PaymentMethod { get; set; }

        public List<OrderItem> Items { get; set; }

        public Order()
        {
            Id = "ORD_" +
                Guid.NewGuid()
                .ToString("N")
                .Substring(0, 8);

            Items = new List<OrderItem>();

            OrderDate = DateTime.Now;

            Status = OrderStatusEnum.Pending;
        }

        public decimal TotalAmount()
        {
            return Items.Sum(item => item.Total());
        }
    }
}