namespace ninjamanager.data.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category() { }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public List<Product> Products { get; set; }
    }
}