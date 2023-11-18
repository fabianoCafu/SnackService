using SnackService.Api.Model;
using System.Collections.Generic;
using System;

namespace SnackService.Api.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public string Observation { get; set; }
        public IEnumerable<Additional> Additional { get; set; } 
        public IEnumerable<Ordered> Ordered { get; set; }
    }
}

