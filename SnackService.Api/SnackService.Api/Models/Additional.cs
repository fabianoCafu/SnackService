using SnackService.Api.Models;
using System;

namespace SnackService.Api.Model
{
    public class Additional
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public string Description { get; set; }
        public int Status  { get; set; }
        public virtual Category Category { get; set; }
    }
}
