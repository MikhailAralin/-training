namespace WorkshopLib
{
    public class Protein : Food
    {
        public Protein(string name, string country, string description, DateTime productionDate) : base(name, country, description, productionDate)
        { }
        public bool HasShelfLife => SearchForExpirationDate();
        public bool SearchForExpirationDate()
        {
            return true;
        }
    }
}
