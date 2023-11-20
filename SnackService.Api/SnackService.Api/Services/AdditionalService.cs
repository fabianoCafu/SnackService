//using Microsoft.EntityFrameworkCore;
//using SnackService.Api.Context;
//using SnackService.Api.Services.interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace SnackService.Api.Services
//{
//    public class AdditionalService : IAdditionalService
//    {
//        private readonly AppDbContext _context;

//        public AdditionalService(AppDbContext context)
//        {
//            _context = context;
//        }

//        public async Task CreateAdditional(Additional additional)
//        {
//            _context.Additionals.Add(additional);
//            await _context.SaveChangesAsync();
//        }

//        public async Task UpdateAdditional(Additional additional)
//        {
//            _context.Entry(additional).State = EntityState.Modified;
//            await _context.SaveChangesAsync();
//        }

//        public async Task DeleteAdditional(Additional additional)
//        {
//            _context.Additionals.Remove(additional);
//            await _context.SaveChangesAsync();
//        }

//        public async Task<Additional> GetAdditional(Guid id)
//        {
//            return await _context.Additionals.FindAsync(id);
//        }

//        public async Task<IEnumerable<Additional>> GetAllAdditional(
//            int page = 1,
//            int additionalByPage = 10)
//        {
//            return await _context.Additionals
//                                 .Skip((page - 1) * additionalByPage)
//                                 .Take(additionalByPage)
//                                 .ToListAsync();
//        }
//    }
//}
