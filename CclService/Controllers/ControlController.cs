using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Api.Aplication.Services;


namespace CclService.Controllers
{

    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ControlController : ControllerBase
    {
        private readonly ControlService _service;
        private readonly ILogger<ControlController> _logger;
        public ControlController(ControlService service, ILogger<ControlController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var items = await _service.GetAllProductAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> GetProductsById([FromBody] Producs request)
        {
            var created = await _service.CreateAsync(request);
            return CreatedAtAction(nameof(GetAll), created);
        }

        [HttpPut]
        public async Task<IActionResult> ProductsById([FromBody] Producs request)
        {
            var updated = await _service.UpdateAsync(request);
            return Ok(updated);
        }   

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductsById(Guid id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
