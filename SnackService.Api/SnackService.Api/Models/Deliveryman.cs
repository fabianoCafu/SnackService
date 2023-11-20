using System;
using System.Collections.Generic;

namespace SnackService.Api.Model
{
    public class Deliveryman
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Cpf { get; set; }
        public int Status { get; set; }

        public IEnumerable<Ordered> Ordered { get; set; }

        public Deliveryman()
        {
            this.Ordered = new HashSet<Ordered>();
        }

    }
}
