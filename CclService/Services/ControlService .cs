using CclService.Dtos;
using CclService.Interfaces;

namespace CclService.Services
{
    public class ControlService : IControlservice
    {
        public Task<ProductDto> CreateAsync(PoductRequest request)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> CreateAsync(ProductDto.Producs request)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
