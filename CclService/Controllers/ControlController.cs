using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Web.Api.Aplication.Services;
using Web.Api.Domain.DTOs;
using Web.Api.Domain.Interfaces;


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
        //pendiente por implementar
        [HttpPost]
        public async Task<IActionResult> GetProductsById([FromBody] ProductoDto request)
        {
            //var created = await _service.CreateAsync(request);
            return await Task.FromResult(Ok(request));
        }
        //pendiente por implementar
        [HttpPut]
        public async Task<IActionResult> ProductsById([FromBody] ProductoDto request)
        {
            //var updated = await _service.UpdateAsync(request);
            return Ok();
        }
        //pendiente por implementar
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductsById(Guid id)
        {
            //await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}
