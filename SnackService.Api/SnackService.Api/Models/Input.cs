using SnackService.Api.Enum;
using System;
using System.Collections.Generic;

namespace SnackService.Api.Models
{
    public class Input
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Description { get; set; }
        public EnumActive Status { get; set; }
        public string Observation { get; set; }
        public virtual Category Category { get; set; }

        //public ICollection<Category> Category { get; private set; }

        //public Input()
        //{
        //    this.Category = new HashSet<Category>();
        //}
    }
}

