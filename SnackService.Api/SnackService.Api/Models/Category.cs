using SnackService.Api.Enum;
using System;
using System.Collections.Generic;

namespace SnackService.Api.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public EnumActive Status { get; set; }
        public string Observation { get; set; }
        public IEnumerable<Input> Input { get; set; }
    }
}

