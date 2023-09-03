namespace DataAccess.Public.Dto
{
    public class CustomerOrderDto
    {
        public CustomerDto Customer { get; set; }
        public List<OrderDto> Orders { get; set; }
    }
}
