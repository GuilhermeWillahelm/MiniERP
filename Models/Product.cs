namespace MiniERP.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? NameProduct { get; set; }
        public int ProductId { get; set; }
        public string? DescriptionProduct { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }

    }
}
