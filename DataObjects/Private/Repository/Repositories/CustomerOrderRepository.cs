using DataAccess.Private.Models;
using DataAccess.Private.Repository.Context;
using DataAccess.Private.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Private.Repository.Repositories
{
    internal class CustomerOrderRepository : ICustomerOrderRepository
    {
        private readonly CustomerOrderContext _customerOrderContext;

        public CustomerOrderRepository()
        {
            _customerOrderContext = new();
        }

        public Task<List<Customer>> GetAll()
        {
            var customers = _customerOrderContext.Customers.Include(c => c.Orders).ToList();
            return Task.FromResult(customers);
        }
    }
}
