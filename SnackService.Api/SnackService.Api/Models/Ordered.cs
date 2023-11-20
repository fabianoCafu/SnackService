using SnackService.Api.Enum;
using System;

namespace SnackService.Api.Model
{
    public class Ordered
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? DeliverymanId { get; set; }
        public DateTime DateHour { get; set; }
        public string Description { get; set; }
        public string Observation { get; set; }
        public EnumStatusPedido Status { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Deliveryman Deliveryman { get; set; }
    }
}


