using Microsoft.EntityFrameworkCore;
using System;
using Web.Api.Domain.DTOs;

namespace Web.Api.Infraestructure.DBContext
{
    public class APDBContext : DbContext  
    {
        public DbSet<ProductoDto> Productos { get; set; }
        public APDBContext(DbContextOptions<APDBContext> options) : base(options) { }
    }
}
