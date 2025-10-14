using CclService.Dtos;
using static CclService.Dtos.ProductDto;

namespace CclService.Interfaces
{
    public interface IControlservice
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<ProductDto> CreateAsync(Producs request);
        Task DeleteAsync(Guid id);
    }
}
