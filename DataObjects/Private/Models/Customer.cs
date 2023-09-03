namespace DataAccess.Private.Models
{
    internal class Customer
    {
        public long CustomerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public List<Order> Orders { get; set; } = new();
    }
}
