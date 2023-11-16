using SnackService.Api.Enum;
using System;

namespace SnackService.Api.Model
{
    public class Ordered
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? DeliverymanId { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
        public string Description { get; set; }
        public TipoStatus StatusType { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Deliveryman Deliveryman { get; set; }
    }
}


