namespace WorkshopLib
{
    public abstract class StoreItem
    {
        public StoreItem(string name, string country, string description)
        {
            Name = name;
            Country = country;
            Description = description;
        }
        public string Name { get; init; }
        public int Id { get; init; }
        public string Country { get; init; }
        public string Description { get; init; }
    }
}
