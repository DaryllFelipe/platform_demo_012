namespace DataAccess.Private.Models
{
    internal class Order
    {
        public long OrderId { get; set; }
        public long CustomerId { get; set; }
        public long OrderNumber { get; set; }
        public decimal Amount { get; set; }
    }
}
