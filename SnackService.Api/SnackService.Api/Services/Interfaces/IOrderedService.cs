using SnackService.Api.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace ApiSnackService.Service.Interface
{
    public interface IOrderedService
    {
        Task CreateOrdered(Ordered ordered);
        Task UpdateOrdered(Ordered ordered);
        Task DeleteOrdered(Ordered ordered);
        Task<Ordered> GetOrdered(Guid id);
        Task<IEnumerable<Ordered>> GetAllOrdered(int page, int pageSize);
        Task<IEnumerable<Ordered>> GetOrdersByDate(DateTime date);
        Task<IEnumerable<Ordered>> GetOrdersByCustomer(string cpf);
    }
}
