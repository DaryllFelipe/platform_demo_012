using DataAccess.Private.Models;
using DataAccess.Private.Repository.Context;
using DataAccess.Private.Repository.Interfaces;

namespace DataAccess.Private.Repository.Repositories
{
    internal class CustomerOrderRepository : ICustomerOrderRepository
    {
        private readonly CustomerOrderContext _customerOrderContext;

        public CustomerOrderRepository()
        {
            _customerOrderContext = new();
        }

        public Task<List<Customer>> GetAllCustomers()
        {
            var customers = _customerOrderContext.Customers.ToList();
            return Task.FromResult(customers);
        }

        public Task<List<Order>> GetAllOrders(long customerId)
        {
            var Order = _customerOrderContext.Orders.Where(o => o.CustomerId == customerId).ToList();
            return Task.FromResult(Order);
        }
    }
}
