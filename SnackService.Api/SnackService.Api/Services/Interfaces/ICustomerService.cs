using SnackService.Api.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace SnackService.Api.Service.Interface
{
    public interface ICustomerService
    {
        Task CreateCustomer(Customer customer);
        Task UpdateCustomer(Customer customer);
        Task DeleteCustomer(Customer customer);
        Task<Customer> GetCustomer(Guid id);
        Task<IEnumerable<Customer>> GetAllCustomer(int page, int pageSize); 
        Task<IEnumerable<Customer>> GetCustomerByName(string name);
        Task GetCustomerAddress(string zipCode);
    }
}
