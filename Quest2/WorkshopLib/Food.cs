namespace WorkshopLib
{
    public class Food : StoreItem, IHasShelfLife
    {
        public Food(string name, string country, string description, DateTime productionDate) : base(name, country, description)
        {
            ProductionDate = productionDate;
        }
        public bool HasShelfLife => true;
        public DateTime ProductionDate { get; init; }
        public DateTime ExpirationDate;
        public bool SearchForExpirationDate()
        {
            return true;
        }
    }
}
