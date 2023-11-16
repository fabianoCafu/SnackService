using SnackService.Api.Context;
using SnackService.Api.Model;
using SnackService.Api.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SnackService.Api.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomer(Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
        }

        public async Task<Customer> GetCustomer(Guid id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<IEnumerable<Customer>> GetCustomerByName(string name)
        {
            return !string.IsNullOrWhiteSpace(name)
                ? await _context.Customers.Where(c => c.Name.Contains(name)).ToListAsync()
                : await GetAllCustomer();
        }

        public async Task<IEnumerable<Customer>> GetAllCustomer(
            int page = 1,
            int customersByPage = 10)
        {
            return await _context.Customers
                                 .Skip((page - 1) * customersByPage)
                                 .Take(customersByPage)
                                 .ToListAsync();
        }

        Task ICustomerService.GetCustomerAddress(string zipCode)
        {
            throw new NotImplementedException();
        }
    }
}
