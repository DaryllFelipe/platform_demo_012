using DataAccess.Private.Repository.Interfaces;
using DataAccess.Public.Dto;
using DataAccess.Public.Interaces.Services;

namespace DataAccess.Private.Services
{
    internal class CustomerService : ICustomerService
    {
        private readonly ICustomerOrderRepository _customerOrderRepository;
        public CustomerService(ICustomerOrderRepository customerOrderRepository)
        {
            _customerOrderRepository = customerOrderRepository;
        }

        public async Task<List<CustomerOrderDto>> GetAllCustomer()
        {
            var customerOrders = new List<CustomerOrderDto>();
            var rawCustomerOrders = await _customerOrderRepository.GetAll();
            if (rawCustomerOrders != null && rawCustomerOrders.Any())
            {
                foreach (var customer in rawCustomerOrders)
                {
                    CustomerOrderDto customerData = new()
                    {
                        Customer = new CustomerDto()
                        {
                            CustomerId = customer.CustomerId,
                            Name = customer.Name,
                            PhoneNumber = customer.PhoneNumber,
                        },
                        Orders = new()
                    };
                    if (customer.Orders != null && customer.Orders.Any())
                    {
                        foreach (var order in customer.Orders)
                        {
                            customerData.Orders.Add(new OrderDto()
                            {
                                Amount = order.Amount,
                                CustomerId = customer.CustomerId,
                                OrderId = order.OrderId,
                                OrderNumber = order.OrderNumber,
                            });
                        }
                    }
                    else
                    {
                        customerData.Orders = new List<OrderDto>();
                    }
                    customerOrders.Add(customerData);
                }
            }
            return customerOrders;
        }
    }
}
