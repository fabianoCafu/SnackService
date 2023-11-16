using System;
using System.Collections.Generic;

namespace SnackService.Api.Model
{
    public class Deliveryman
    {
        public Guid Id { get; set; }
        
        public IEnumerable<Ordered> Ordered { get; set; }
    }
}
