using System.Threading.Tasks;
using Web.Api.Domain.DTOs;
using Web.Api.Infraestructure.Interface;
using Web.Api.Infraestructure.DBContext;

namespace Web.Api.Infraestructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly APDBContext _dBContext;

        public ProductRepository(APDBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public async Task<ProductoDto> GetAllProductAsync()
        {
            return await _dBContext.Productos.FindAsync();
        }
    }
}
