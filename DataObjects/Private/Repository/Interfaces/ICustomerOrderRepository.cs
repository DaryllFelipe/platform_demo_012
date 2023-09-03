using DataAccess.Private.Models;

namespace DataAccess.Private.Repository.Interfaces
{
    internal interface ICustomerOrderRepository
    {
        Task<List<Customer>> GetAll();
    }
}
