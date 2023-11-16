using ApiSnackService.Service.Interface;
using SnackService.Api.Context;
using SnackService.Api.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SnackService.Api.Service
{
    public class OrderedService : IOrderedService
    {
        private readonly AppDbContext _context;

        public OrderedService(AppDbContext context)
        {
            _context = context;
        }

        public Task CreateOrdered(Ordered ordered)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrdered(Ordered ordered)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ordered>> GetAllOrdered(
            int page,
            int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Ordered> GetOrdered(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ordered>> GetOrdersByCustomer(string cpf)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ordered>> GetOrdersByDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrdered(Ordered ordered)
        {
            throw new NotImplementedException();
        }
    }
}
