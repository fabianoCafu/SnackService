using ApiSnackService.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SnackService.Api.Model;
using System.Threading.Tasks;
using System;

namespace SnackService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliverymanController : ControllerBase
    {
        private readonly IDeliverymanService _deliveryman;

        public DeliverymanController(IDeliverymanService deliveryman)
        {
            _deliveryman = deliveryman;
        }

        [HttpPost("CreateDeliveryman")]
        public async Task<ActionResult> CreateDeliveryman(Deliveryman ordered)
        {
            await _deliveryman.CreateDeliveryman(ordered);
            return CreatedAtRoute(nameof(GetDeliverymanById), new { id = ordered.Id }, ordered);
        }

        [HttpPut("UpdateDeliveryman")]
        public async Task<ActionResult> UpdateDeliveryman(
            Guid id,
            [FromBody] Deliveryman ordered)
        {
            if (ordered.Id == id)
            {
                await _deliveryman.UpdateDeliveryman(ordered);
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id:Guid}")]
        public async Task<ActionResult> DeleteDeliveryman(Guid id)
        {
            var ordered = await _deliveryman.GetDeliveryman(id);

            if (ordered is not null)
            {
                await _deliveryman.DeleteDeliveryman(ordered);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Deliveryman>> GetDeliverymanById(Guid id)
        {
            var customer = await _deliveryman.GetDeliveryman(id);
            return Ok(customer);
        }
    }
}
