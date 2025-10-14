namespace CclService.Entities
{
    public class Product
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; } = null!;
        public string? Description { get; private set; }
        public int Quantity { get; private set; }
        public DateTime CreatedAt { get; private set; }

        private Product() { } // EF Core

        public Product(string name, string? description, int quantity)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Quantity = quantity;
            CreatedAt = DateTime.UtcNow;
        }

        public void UpdateQuantity(int newQuantity)
        {
            if (newQuantity < 0) throw new ArgumentException("Quantity cannot be negative");
            Quantity = newQuantity;
        }
    }
}
