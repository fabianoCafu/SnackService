using SnackService.Api.Enum;
using SnackService.Api.Models;
using System;

namespace SnackService.Api.Model
{
    public class Ordered
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? DeliverymanId { get; set; }
        public DateTime DateHour { get; set; } 
        public string Description { get; set; }
        public string Observation { get; set; }
        public EnumStatus Status { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Category Category { get; set; }
        public virtual Deliveryman Deliveryman { get; set; }
    }
}


