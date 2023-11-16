using ApiSnackService.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using SnackService.Api.Model;
using System;
using System.Threading.Tasks;

namespace SnackService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderedController : ControllerBase
    {
        private readonly IOrderedService _ordered;

        public OrderedController(IOrderedService ordered)
        {
            _ordered = ordered;
        }

        [HttpPost("CreateOrdered")]
        public async Task<ActionResult> CreateOrdered(Ordered ordered)
        {
            await _ordered.CreateOrdered(ordered);
            return CreatedAtRoute(nameof(GetOrderedById), new { id = ordered.Id }, ordered);
        }

        [HttpPut("UpdateOrdered")]
        public async Task<ActionResult> UpdateOrdered(
            Guid id,
            [FromBody] Ordered ordered)
        {
            if (ordered.Id == id)
            {
                await _ordered.UpdateOrdered(ordered);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> DeleteOrdered(Guid id)
        {
            var ordered = await _ordered.GetOrdered(id);

            if (ordered is not null)
            {
                await _ordered.DeleteOrdered(ordered);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Ordered>> GetOrderedById(Guid id)
        {
            var customer = await _ordered.GetOrdered(id);
            return Ok(customer);
        }
    }
}
