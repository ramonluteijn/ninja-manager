namespace ninjamanager.data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }
        public int Strength { get; set; }
        public int Agility { get; set; }
        public int Intelligence { get; set; }
        public int CategoryId { get; set; }

        public Product() { }

        public Product(int id, string name, int price, string location, int strength, int agility, int intelligence, int categoryId)
        {
            Id = id;
            Name = name;
            Price = price;
            Location = location;
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
            CategoryId = categoryId;
        }

        public Category Category { get; set; }
    }
}