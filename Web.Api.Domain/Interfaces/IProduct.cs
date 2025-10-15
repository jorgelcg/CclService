using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Api.Domain.DTOs;

namespace Web.Api.Domain.Interfaces
{
    public interface IProduct
    {
        Task<ProductoDto> GetAllProductAsync();
    }
}
