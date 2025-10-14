namespace CclService.Dtos
{
    public class ProductDto
    {
        public record Producs(Guid Id, string Name, string? Description, int Quantity, DateTime CreatedAt);
    }
}
