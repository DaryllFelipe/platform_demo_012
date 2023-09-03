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
            var customers = await _customerOrderRepository.GetAllCustomers();
            if (customers != null && customers.Any())
            {
                foreach (var customer in customers)
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

                    var orders = await _customerOrderRepository.GetAllOrders(customer.CustomerId);
                    if (orders != null && orders.Any())
                    {
                        foreach (var order in orders)
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
                    customerOrders.Add(customerData);
                }
            }
            return customerOrders;
        }
    }
}
