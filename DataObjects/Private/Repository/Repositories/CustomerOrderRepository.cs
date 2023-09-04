using DataAccess.Private.Models;
using DataAccess.Private.Repository.Context;
using DataAccess.Private.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Private.Repository.Repositories
{
    internal class CustomerOrderRepository : ICustomerOrderRepository
    {
        private readonly CustomerOrderContext _customerOrderContext;

        /// <summary>
        /// I'd like to create injections for repositories so that the business logic is not tied to any 3rd party libriries and of there are changes, it is easy to change
        /// </summary>
        public CustomerOrderRepository()
        {
            _customerOrderContext = new();
        }

        /// <summary>
        /// Get customer data by Id and all his/her orders
        /// </summary>
        /// <param name="customerId"></param>
        /// <returns></returns>
        public async Task<Customer?> Get(long customerId)
        {
            var customer = await _customerOrderContext.Customers
                           .Include(c => c.Orders) // Include related Orders
                           .SingleOrDefaultAsync(c => c.CustomerId == customerId);
            return customer;
        }

        /// <summary>
        /// Get all customers and their orders
        /// </summary>
        /// <returns></returns>
        public Task<List<Customer>> GetAll()
        {
            var customers = _customerOrderContext.Customers.Include(c => c.Orders).ToList();
            return Task.FromResult(customers);
        }
    }
}
