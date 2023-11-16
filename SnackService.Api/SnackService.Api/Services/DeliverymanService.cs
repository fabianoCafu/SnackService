using ApiSnackService.Service.Interface;
using SnackService.Api.Context;
using SnackService.Api.Controllers;
using SnackService.Api.Model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SnackService.Api.Service
{
    public class DeliverymanService : IDeliverymanService
    {
        public Task CreateDeliveryman(Deliveryman deliveryman)
        {
            throw new NotImplementedException();
        }

        public Task DeleteDeliveryman(Deliveryman deliveryman)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Deliveryman>> GetAllDeliveryman(int page, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<Deliveryman> GetDeliveryman(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Deliveryman>> GetOrdersByDeliveryman(string cpf)
        {
            throw new NotImplementedException();
        }

        public Task UpdateDeliveryman(Deliveryman deliveryman)
        {
            throw new NotImplementedException();
        }
    }
}
