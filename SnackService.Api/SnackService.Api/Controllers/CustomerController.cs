using SnackService.Api.Model;
using SnackService.Api.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SnackService.Api.Integracao.Interface;
using SnackService.Api.Integracao;

namespace SnackService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customer;
        private readonly IViaCepClient _viaCep;

        public CustomerController(
            ICustomerService customer,
            IViaCepClient viaCep)
        {
            _viaCep = viaCep;
            _customer = customer;
        }

        [HttpPost("CreateCustomer")]
        public async Task<ActionResult> CreateCustomer(Customer customer)
        {
            await _customer.CreateCustomer(customer);
            return CreatedAtRoute(nameof(GetCustomerById), new { id = customer.Id }, customer);
        }

        [HttpPut("UpdateCustomer")]
        public async Task<ActionResult> UpdateCustomer(
            Guid id, 
            [FromBody] Customer customer)
        {
            if (customer.Id == id)
            {
                await _customer.UpdateCustomer(customer);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> DeleteCustomer(Guid id)
        {
            var costumer = await _customer.GetCustomer(id);

            if (costumer is not null)
            {
                await _customer.DeleteCustomer(costumer);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("GetAllCustomer")]
        public async Task<ActionResult<IAsyncEnumerator<Customer>>> GetAllCustomer(
            int page,
            int customersByPage)
        {
            var customer = await _customer.GetAllCustomer(page, customersByPage);
            return Ok(customer);
        }

        [HttpGet("GetCustomerByName")]
        public async Task<ActionResult<IAsyncEnumerator<Customer>>> GetCustomerByName(
            [FromQuery] string name)
        {
            var customer = await _customer.GetCustomerByName(name);
            return Ok(customer);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomerById(Guid id)
        {
            var customer = await _customer.GetCustomer(id);
            return Ok(customer);
        }

        [HttpGet("GetCustomerAddress")]
        public ActionResult<ViaCepResponse> GetCustomerAddress(string codeZip)
        {
            var viaCep = _viaCep.Search(codeZip);
            return Ok(viaCep);
        }
    }
}
