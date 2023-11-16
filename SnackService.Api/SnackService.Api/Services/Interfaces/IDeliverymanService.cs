using SnackService.Api.Model;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace ApiSnackService.Service.Interface
{
    public interface IDeliverymanService
    {
        Task CreateDeliveryman(Deliveryman deliveryman);
        Task UpdateDeliveryman(Deliveryman deliveryman);
        Task DeleteDeliveryman(Deliveryman deliveryman);
        Task<Deliveryman> GetDeliveryman(Guid id); 
        Task<IEnumerable<Deliveryman>> GetOrdersByDeliveryman(string cpf);
        Task<IEnumerable<Deliveryman>> GetAllDeliveryman(int page, int pageSize);
    }
}
