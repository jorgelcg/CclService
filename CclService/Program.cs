
using Web.Api.Aplication.Services;
using Web.Api.Domain.Interfaces;
using Web.Api.Infraestructure.DBContext;
using Npgsql;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<ControlService>();
builder.Services.AddScoped<Web.Api.Infraestructure.Interface.IProductRepository, Web.Api.Infraestructure.Repositories.ProductRepository>();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddNpgsql<APDBContext>(connectionString);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();

app.Run();
