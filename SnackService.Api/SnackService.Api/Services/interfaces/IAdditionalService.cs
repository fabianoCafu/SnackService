using SnackService.Api.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace SnackService.Api.Services.interfaces
{
    public interface IAdditionalService
    {
        Task CreateAdditional(Additional additional);
        Task UpdateAdditional(Additional additional);
        Task DeleteAdditional(Additional additional);
        Task<Additional> GetAdditional(Guid id);
        Task<IEnumerable<Additional>> GetAllAdditional(int page, int additionalByPage);
    }
}
