using DataAccess.Public.Dto;

namespace DataAccess.Public.Interaces.Services
{
    public interface ICustomerService
    {
        Task<List<CustomerOrderDto>> GetAllCustomer();
    }
}
