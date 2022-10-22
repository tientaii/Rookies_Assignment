namespace assignment_two.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public string? Manufacture { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}