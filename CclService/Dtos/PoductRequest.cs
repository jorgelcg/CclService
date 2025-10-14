namespace CclService.Dtos
{
    public class PoductRequest
    {
        public record CreatePoductRequest(string Name, string? Description, int Quantity);
    }
}
