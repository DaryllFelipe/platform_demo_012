using DataAccess.Private.Models;
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

        /// <summary>
        /// Get All customer data and all their orders
        /// </summary>
        /// <returns></returns>
        public async Task<List<CustomerOrderDto>> GetAllCustomer()
        {
            var customerOrders = new List<CustomerOrderDto>();
            var rawCustomerOrders = await _customerOrderRepository.GetAll();
            if (rawCustomerOrders != null && rawCustomerOrders.Any())
            {
                foreach (var customer in rawCustomerOrders)
                {
                    //you can see in here I am transfering the data to the dtos, because I dont like the core models
                    //to be accessible to the UI layers.
                    //It is also to prevent unnecessary changes to core models when something is needed to chage regarding
                    //objects
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

        /// <summary>
        /// Get All customer data and all their orders by customer Id
        /// </summary>
        /// <returns></returns>
        public async Task<CustomerOrderDto?> GetByCustomerId(long customerId)
        {
            var rawCustomerOrders = await _customerOrderRepository.Get(customerId);
            if (rawCustomerOrders != null)
            {
                CustomerOrderDto customerData = new()
                {
                    Customer = new CustomerDto()
                    {
                        CustomerId = rawCustomerOrders.CustomerId,
                        Name = rawCustomerOrders.Name,
                        PhoneNumber = rawCustomerOrders.PhoneNumber,
                    },
                    Orders = new()
                };
                if (rawCustomerOrders.Orders != null && rawCustomerOrders.Orders.Any())
                {
                    foreach (var order in rawCustomerOrders.Orders)
                    {
                        customerData.Orders.Add(new OrderDto()
                        {
                            Amount = order.Amount,
                            CustomerId = rawCustomerOrders.CustomerId,
                            OrderId = order.OrderId,
                            OrderNumber = order.OrderNumber,
                        });
                    }
                }
                else
                {
                    customerData.Orders = new List<OrderDto>();
                }
                return customerData;
            }
            return null;
        }
    }
}
