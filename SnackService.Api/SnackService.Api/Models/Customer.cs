using SnackService.Api.Enum;
using System;

namespace SnackService.Api.Model
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Telephone { get; set; }
        public string Address { get; set; }
        public int Number { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; } 
        public CustomerSex Sex { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}