namespace ninjamanager.Models
{
    public class ShopItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public ShopItem() { }

        public ShopItem(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}