using CclService.Dtos;
using CclService.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using static CclService.Dtos.ProductDto;

namespace CclService.Controllers
{

    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ControlController : ControllerBase
    {
        private readonly IControlservice _service;
        private readonly ILogger<ControlController> _logger;
        public ControlController(IControlservice service, ILogger<ControlController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var items = await _service.GetAllAsync();
            return Ok(items);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Producs request)
        {
            var created = await _service.CreateAsync(request);
            return CreatedAtAction(nameof(GetAll), created);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
