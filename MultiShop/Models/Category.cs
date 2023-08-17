namespace MultiShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int ProductCount { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
